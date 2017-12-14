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
    class ManualController
    {
        private ModbusTCP.Master MBmaster;
        private byte[] result;
        Motor ManualMotor;
        Timer timer = new Timer();
        bool running;
        double Degrees;

        public ManualController()
        {
            ManualMotor = new Motor();
        }

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

        public void WriteMotor(int Velocity, int Acceleration, int Deceleration, double Counts, double Degrees)
        {
            this.Degrees = Degrees;

            ManualMotor.InputData.SetpointVelocity.Set(Velocity);
            ManualMotor.InputData.Acceleration.Set(Acceleration);
            ManualMotor.InputData.Deceleration.Set(Deceleration);
            if (Degrees < 0) //Counterclockwise
            {
                ManualMotor.InputData.Control_I3.Negative = false;
                ManualMotor.InputData.Control_I3.Positive = true;
            }
            else
            {
                ManualMotor.InputData.Control_I3.Negative = true;
                ManualMotor.InputData.Control_I3.Positive = false;
            }
            UpdateMotor();

            RotationalScaler Scaler = new RotationalScaler(Counts, ManualMotor.OutputData.Position.Get());
            ManualMotor.AddScaler(Scaler);

            running = true;
            timer.Interval = 100; //ms
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        public void StopMotor()
        {
            running = false;
            ManualMotor.InputData.SetpointVelocity.Set(0);
            if (ManualMotor.InputData.Deceleration.Get() == 0)
                ManualMotor.InputData.Deceleration.Set(ManualMotor.OutputData.Velocity.Get()/2);
            UpdateMotor();
        }

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
                   
                    Console.WriteLine("Degrees " + Degrees);
                    Console.WriteLine("Current Velocity " + ManualMotor.OutputData.Velocity.Get());
                    Console.WriteLine("Target Pos " + (TargetPosition));
                    Console.WriteLine("Current Pos " + ManualMotor.OutputData.Position.Get());
                    Console.WriteLine("-------------------------");

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
                    Console.WriteLine("Final Position" + ManualMotor.OutputData.Position.Get());
                }
            }
            UpdateMotor();
        }

        public bool TimerIsRunning()
        {
            if(timer != null)
                return timer.Enabled;
            return false;
        }

        public Motor getMotor()
        {
            return ManualMotor;
        }

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
    }
}