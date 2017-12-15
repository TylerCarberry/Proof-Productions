using System;
using System.Net;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ModbusTCP;
using System.Diagnostics;
using Proof_Productions.Model;
using Proof_Productions.Model.Input;
using Proof_Productions.Model.Output;

namespace Proof_Productions.Controller
{
    public class ManualController
    {
        private DataAccess data = new DataAccess();
        private ModbusTCP.Master MBmaster;
        private byte[] result;
        Motor ManualMotor = new Motor();
        Timer timer = new Timer();
        bool running;
        double Degrees;
        bool DebugFlag = true;

        public ManualController()
        {

        }

        /// <summary>
        /// Create ModbusTCP Master object for the motor.
        /// </summary>
        public void ConnectMotor()
        {
            try
            {
                //Create new modbus master and add event functions
                MBmaster = new Master(ManualMotor.IPAddress, 502);

                MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);
                // Show additional fields, enable watchdog
          
                Logger.LogInfo("Successfully connected to " + ManualMotor.Name + " at address: " + ManualMotor.IPAddress);
            }
            catch (SystemException error)
            {
                MessageBox.Show(error.Message);
                Logger.LogError("Failed to conntect to motor. " + error.ToString());
            }
        }

        // ------------------------------------------------------------------------
        // Modbus TCP slave exception
        // ------------------------------------------------------------------------
        private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
        {
            string exc = "Modbus says error: ";
            switch (exception)
            {
                case Master.excIllegalFunction: exc += "Illegal function!"; break;
                case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
                case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
                case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
                case Master.excAck: exc += "Acknoledge!"; break;
                case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
                case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
                case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
                case Master.excExceptionNotConnected: exc += "Not connected!"; break;
            }

            Logger.LogError(exc);

            MessageBox.Show(exc, "Modbus slave exception");
        }

        /// <summary>
        /// Writes to a motor using only its Speed, Acceleration, Deceleration and Direction.
        /// Basic Motor.
        /// </summary>
        public void WriteMotor(int Velocity, int Acceleration, int Deceleration, bool Negative)
        {
            Console.WriteLine("Deceleration Set at " + Deceleration);
            ManualMotor.InputData.SetpointVelocity.Set(Velocity);
            ManualMotor.InputData.Acceleration.Set(Acceleration);
            ManualMotor.InputData.Deceleration.Set(Deceleration);
            ManualMotor.InputData.Control_I3.Negative = Negative;
            ManualMotor.InputData.Control_I3.Positive = !Negative;
            
            running = true;
            timer.Interval = 50; //ms
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        /// <summary>
        /// Writes to a rotational motor using it Velocity, Acceleration, Deceleration, Degrees per Count, and Degrees
        /// Motor will spin the entered degree amount and stop.
        /// Tries to accounts for the distance traveled when slowing down.
        /// May need more precision for stopping.
        /// </summary>
        public void WriteMotor(int Velocity, int Acceleration, int Deceleration, double Counts, double Degrees)
        {
            this.Degrees = Degrees;

            ManualMotor.InputData.SetpointVelocity.Set(Velocity);
            ManualMotor.InputData.Acceleration.Set(Acceleration);
            ManualMotor.InputData.Deceleration.Set(Deceleration);
            if (Degrees < 0) //Counterclockwise Spin
            {
                ManualMotor.InputData.Control_I3.Negative = false;
                ManualMotor.InputData.Control_I3.Positive = true;
            }
            else //Clockwise Spin
            {
                ManualMotor.InputData.Control_I3.Negative = true;
                ManualMotor.InputData.Control_I3.Positive = false;
            }
            UpdateMotor();

            RotationalScaler Scaler = new RotationalScaler(Counts, ManualMotor.OutputData.Position.Get());
            ManualMotor.AddScaler(Scaler);

            running = true;
            timer.Interval = 100; //Timer uses ms
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        /// <summary>
        /// Stops a motor, works for both basic and rotational motors.
        /// </summary>
        public void StopMotor()
        {
            running = false;
            ManualMotor.InputData.SetpointVelocity.Set(0);
            if (ManualMotor.InputData.Deceleration.Get() == 0)
                ManualMotor.InputData.Deceleration.Set(ManualMotor.OutputData.Velocity.Get()/2);
            UpdateMotor();
        }

        /// <summary>
        /// Actually writes to the motor. 
        /// Used when running and stopping the motor.
        /// </summary>
        public void UpdateMotor()
        {
            ushort ID = 8;
            ushort StartAddress = 4;
            byte unit = 0;

            if (MBmaster == null)
            {
                Logger.LogError("Attempting to write to null motor. Write failed.");
                return;
            }
            MBmaster.ReadWriteMultipleRegister(ID, unit, StartAddress, 12, StartAddress, ManualMotor.InputData.GetValues(), ref result);
            ManualMotor.OutputData.SetValues(result);
        }

        /// <summary>
        /// Called every timer ticks.
        /// If controlling a motor with degrees, then the stopping position is calculated
        /// and the motor starts to stop before the position such that the motor
        /// reaches the stopping position when it reaches a complete stop.
        /// 
        /// If controlling a basic motor, writes to the motor to keep it spinning.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            if (MBmaster == null)
            {
                Logger.LogError("Attempting to write to null motor. Write failed.");
                return;
            }
            if (running)
            {
                if (ManualMotor.HasScaler())
                {
                    double DecelTime = Math.Abs(ManualMotor.OutputData.Velocity.Get() / ManualMotor.InputData.Deceleration.Get());
                    double AvgVelocity = ManualMotor.OutputData.Velocity.Get() / 2; 
                    double Distance = AvgVelocity * DecelTime;
                    double TargetPosition = 0;
                    TargetPosition = ManualMotor.GetScaler().GetInitialPosition() - (Degrees * ManualMotor.GetScaler().GetCountsPerRev());
                    if (DebugFlag)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Degrees " + Degrees);
                        Console.WriteLine("Current Velocity " + ManualMotor.OutputData.Velocity.Get());
                        Console.WriteLine("Target Pos " + (TargetPosition));
                        Console.WriteLine("Current Pos " + ManualMotor.OutputData.Position.Get());
                        Console.WriteLine("---------------------------------");
                    }
                    if (TargetPosition < 0)
                    {
                        if (ManualMotor.InputData.Control_I3.Positive && ManualMotor.OutputData.Position.Get() >= (TargetPosition - Distance*100))
                            StopMotor();
                        else if (ManualMotor.InputData.Control_I3.Negative && (ManualMotor.OutputData.Position.Get() <= (TargetPosition - Distance*100)))
                            StopMotor();
                    }
                    else
                    {
                        if (ManualMotor.InputData.Control_I3.Positive && ManualMotor.OutputData.Position.Get() >= (TargetPosition - Distance*100))
                            StopMotor();
                        else if (ManualMotor.InputData.Control_I3.Negative && (ManualMotor.OutputData.Position.Get() <= (TargetPosition - Distance*100)))
                            StopMotor();
                    }
                }
            }
            else
            {
                if (ManualMotor.OutputData.Velocity.Get() == 0)
                {
                    timer.Stop();
                    if (DebugFlag)
                    {
                        Console.WriteLine("Final Position" + ManualMotor.OutputData.Position.Get());
                    }
                }
            }
            UpdateMotor();
        }

        /// <summary>
        /// Returns true if the timer is running.
        /// Checks if a timer exists first.
        /// </summary>
        public bool TimerIsRunning()
        {
            if(timer != null)
                return timer.Enabled;
            return false;
        }

        /// <summary>
        /// Emergency stop for motor.
        /// Sends ContorllerInhibit bit to motor and stops timer.
        /// </summary>
        public void Estop()
        {
            if (running)
            {
                running = false;
                ManualMotor.InputData.Control_I3.ControllerInhibit = true;
                UpdateMotor();
                timer.Stop();
            }
        }

        /// <summary>
        /// Retrieve all of the motors and their information
        /// </summary>
        /// <returns> A DataTable with all motors and their information </returns>
        public DataTable GetMotors()
        {
            DataTable table = null;
            try
            {
                data.Connect();
                table = data.GetMotors();
                data.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not fetch motors due to : \n" + e.ToString());
            }
            return table;
        }

        /// <summary>
        /// Retrieve all correspoonding information for the specified motor name
        /// </summary>
        /// <param name="Name"> The name of the motor </param>
        /// <returns> A DataTable containing all the motor's information </returns>
        public DataTable GetMotorInfo(String Name)
        {
            DataTable table = null;
            try
            {
                data.Connect();
                table = data.GetMotorInfo(Name);
                data.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not fetch motors due to : \n" + e.ToString());
            }
            return table;
        }
    }
}