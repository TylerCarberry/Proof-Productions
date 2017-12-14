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

        public void WriteMotor(int Velocity, int Acceleration, int Deceleration)
        {

            ManualMotor.InputData.SetpointVelocity.Set(Velocity);
            ManualMotor.InputData.Acceleration.Set(Acceleration);
            ManualMotor.InputData.Deceleration.Set(Deceleration);

            running = true;
            timer.Interval = 100; //ms
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        public void WriteMotor(int Velocity, int Acceleration, int Deceleration, double Counts, double Degrees)
        {
            this.Degrees = Degrees;

            ManualMotor.InputData.SetpointVelocity.Set(Velocity);
            ManualMotor.InputData.Acceleration.Set(Acceleration);
            ManualMotor.InputData.Deceleration.Set(Deceleration);

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

            if(running)
            {
                if(ManualMotor.HasScaler())
                {
                    double DecelTime = ManualMotor.OutputData.Velocity.Get() / ManualMotor.InputData.Deceleration.Get();
                    double AvgVelocity = ManualMotor.OutputData.Velocity.Get() / 2;
                    double Distance = AvgVelocity * DecelTime;
                    double TargetPosition = ManualMotor.GetScaler().GetInitialPosition() + (Degrees * ManualMotor.GetScaler().GetCountsPerRev());
                    if ((TargetPosition - Distance) <= 0)
                    {
                        StopMotor();
                    }
                }
                UpdateMotor();     
            }
            else
            {
                if (ManualMotor.OutputData.Velocity.Get() == 0)
                {
                    timer.Stop();
                }
            }
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