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
using System.Collections.Generic;

namespace Proof_Productions.Controller
{
    class Curve
    {
        private Cue CurrentCue = new Cue();
        private byte[] result;
        private bool FinishedCue;
        private bool estopped = false;
        List<CueItem> ItemList;
        Motor ControlMotor = new Motor();
        Timer timer = new Timer();
        Stopwatch stopwatch = new Stopwatch();
        Master MBmaster;
        private bool DebugFlag = true;

        private void SetupMotor()
        {
            try
            {
                MBmaster = new Master(ControlMotor.IPAddress, 502);
                MBmaster.OnException += new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
                Logger.LogInfo("Successfully connected to: " + ControlMotor.Name + " at IP Address " + ControlMotor.IPAddress);
            }
            catch (SystemException error)
            {
                Logger.LogError(error.Message);
                Logger.LogError("Error connecting to: " + ControlMotor.Name + " at IP Address " + ControlMotor.IPAddress);
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// ModbusTCP exceptions from sample program.
        /// </summary>
        private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
        {
            if (estopped)
            {
                return;
            }

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

            MessageBox.Show(exc, "Modbus slave exception");
            Logger.LogError(exc.ToString());
        }

        private void SetupCue()
        {
            CurrentCue.Add(new CueItem(1, 0, ControlMotor, 100, 20, 20, true, 0));
            CurrentCue.Add(new CueItem(8, 0, ControlMotor, 800, 100, 100, true, 0));
            CurrentCue.Add(new CueItem(19, 0, ControlMotor, 500, 30, 30, true, 0));
            CurrentCue.Add(new CueItem(26, 0, ControlMotor, 300, 70, 70, true, 0));
            CurrentCue.Add(new CueItem(32, 0, ControlMotor, 600, 35, 35, true, 0));
            CurrentCue.Add(new CueItem(40, 10, ControlMotor, 100, 30, 30, true, 0));

            ItemList = CurrentCue.GetList();
            foreach(CueItem Item in ItemList)
            {
                Item.Running = true;
            }
        }

        public void PlayCurrentCue()
        {
            Logger.LogInfo("Playing " + CurrentCue.Name);
            if (DebugFlag)
                Console.WriteLine("Curve has begun.");
            SetupMotor();
            SetupCue();
            FinishedCue = false;
            stopwatch.Start();
            timer.Interval = 100; //ms
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            if (DebugFlag)
            {
                Console.WriteLine("Current Velocity is 0");
                Console.WriteLine("Changing Velocity to " + ItemList[0].SetVelocity);
                Console.WriteLine("Changing to Acceleration " + ItemList[0].SetAcceleration);
                Console.WriteLine("Changing to Deceleration " + ItemList[0].SetDeceleration);
            }
        }

        /// <summary>
        /// Private method for playing a cue.
        /// Handles when each cue item starts or ends.
        /// Handels when the cue is finished.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            int NumberRunning = ItemList.Count;
            for (int Count = 0; Count < ItemList.Count; Count++)
            {
                CueItem Item = ItemList[Count];
                bool skip = false;
                if (!FinishedCue)
                {
                    if (stopwatch.Elapsed.Seconds >= Item.DelayBefore)
                    {
                        if (Item.Running)
                        {
                            if (Item.RunTime == 0)
                            {
                                if (Count + 1 < ItemList.Count && ItemList[Count + 1].DelayBefore <= stopwatch.Elapsed.Seconds)
                                {
                                    Item.Running = false;
                                    skip = true;
                                    if (DebugFlag)
                                    {
                                        Console.WriteLine("------------------------");
                                        Console.WriteLine("Current Velocity is " + Item.CueMotor.OutputData.Velocity.Get());
                                        Console.WriteLine("Changing Velocity to " + ItemList[Count + 1].SetVelocity);
                                        Console.WriteLine("Changing to Acceleration " + ItemList[Count + 1].SetAcceleration);
                                        Console.WriteLine("Changing to Deceleration " + ItemList[Count + 1].SetDeceleration);
                                        Console.WriteLine("------------------------");
                                    }
                                }
                            }
                            else if (stopwatch.Elapsed.Seconds >= (Item.DelayBefore + Item.RunTime - (Item.CueMotor.InputData.SetpointVelocity.Get() / Item.CueMotor.InputData.Deceleration.Get())))
                            {
                                if (!Item.Stopping)
                                {
                                    Item.Stopping = true;
                                    Item.SetVelocity = 0;
                                }
                                else if (Item.CueMotor.OutputData.Velocity.Get() == 0)
                                {
                                    Item.Running = false;
                                    Logger.LogInfo("Motor " + Item.CueMotor.Name + " has stopped running");
                                }
                            }
                            if (!skip)
                            {
                                Item.UpdateInputFields();
                                MBmaster.ReadWriteMultipleRegister(8, 0, 4, 12, 4, CurrentCue.GetList()[Count].CueMotor.InputData.GetValues(), ref result);
                                Item.CueMotor.OutputData.SetValues(result);
                            }
                        }
                        else
                        {
                            NumberRunning--;
                        }
                    }
                    if (NumberRunning == 0)
                    {
                        FinishedCue = true;
                    }
                }
                else
                {
                    stopwatch.Stop();
                    timer.Stop();
                    Logger.LogInfo("Cue " + CurrentCue.Name + " has stopped running");
                    if (DebugFlag)
                    {
                        Console.WriteLine("Current Velocity: " + ItemList[Count + 1].CueMotor.OutputData.Velocity.Get());
                        Console.WriteLine("Curve has stopped.");
                    }
                    return;
                }
            }
        }
    }
}
