﻿using System;
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
    public class PlayCueController
    {
        private DataAccess data = new DataAccess();
        private Cue CurrentCue = new Cue();
        private byte[] result;
        private bool FinishedCue;
        private bool estopped = false;
        private List<Cue> CueList = new List<Cue>();
        private List<Master> MasterList = new List<Master>();
        Timer timer = new Timer();
        Stopwatch stopwatch = new Stopwatch();

        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Proof of concept hard coded cue sample in constructor
        // --------------------------------------------------------------------------------------------------------------------------------------------
        public PlayCueController()
        {
            Cue Cue1 = new Cue();
            Motor Motor1 = new Motor();
            CueItem Item = new CueItem(5, 10, Motor1, 500, 100, 100, false, 0);
            Cue1.Add(Item);
            Item = new CueItem(25, 20, Motor1, 300, 100, 100, false, 0);
            Cue1.Add(Item);
            CueList.Add(Cue1);
            CurrentCue = CueList[0];
        }

        // ---------------------------------------------------------------
        // Methods
        // ---------------------------------------------------------------
        private void SetupMotors()
        {
            List<CueItem> ItemList = CurrentCue.GetList();
            foreach (CueItem Item in ItemList)
            {
                try
                {
                    Master MBmaster = new Master(Item.CueMotor.IPAddress, 502);
                    MBmaster.OnException += new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
                    Logger.LogInfo("Successfully connected to: " + Item.CueMotor.Name + " at IP Address " + Item.CueMotor.IPAddress);
                    MasterList.Add(MBmaster);
                    Item.CueMotor.InputData.Control_I3.ControllerInhibit = false;
                    Item.UpdateInputFields();
                    Item.Running = true;
                    Item.Stopping = false;

                }
                catch (SystemException error)
                {
                    Logger.LogError("Error connecting to: " + Item.CueMotor.Name + " at IP Address " + Item.CueMotor.IPAddress);
                    Logger.LogError(error.Message);
                    MessageBox.Show(error.Message);
                }
            }
        }

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

        public void PlayCurrentCue()
        {
            Logger.LogInfo("Playing " + CurrentCue.Name);
            SetupMotors();
            FinishedCue = false;
            stopwatch.Start();
            timer.Interval = 100; //ms
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            int NumberRunning = MasterList.Count;
            for (int Count = 0; Count < MasterList.Count; Count++)
            {
                CueItem Item = CurrentCue.GetList()[Count];

                if (!FinishedCue)
                {
                    if (stopwatch.Elapsed.Seconds >= Item.DelayBefore)
                    {
                        if (Item.Running)
                        {
                            if (stopwatch.Elapsed.Seconds >= (Item.DelayBefore + Item.RunTime - (Item.CueMotor.InputData.SetpointVelocity.Get() / Item.CueMotor.InputData.Deceleration.Get())))
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
                            Item.UpdateInputFields();
                            MasterList[Count].ReadWriteMultipleRegister(8, 0, 4, 12, 4, CurrentCue.GetList()[Count].CueMotor.InputData.GetValues(), ref result);
                            Item.CueMotor.OutputData.SetValues(result);
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
                    DisconnectMotors();
                    Logger.LogInfo("Cue " + CurrentCue.Name + " has stopped running");
                }
            }
        }

        private void DisconnectMotors()
        {
            foreach (Master Item in MasterList)
            {
                Item.Dispose();
            }
        }

        public void StopCurrentCue()
        {
            FinishedCue = true;
        }

        public void ChangeCurrentCueWithIndex(int Index)
        {
            CurrentCue = CueList[Index];
        }
    
        public void ChangeCurrentCueWithCue(Cue SelectedCue)
        {
            CurrentCue = SelectedCue;
        }

        public void RemoveCueAtIndex(int Index)
        {
            if (ValidIndexForLists(Index, CueList.Count))
                CueList.RemoveAt(Index);
            else
                MessageBox.Show("Cannot Remove: Invalid Index");
        }

        private Boolean ValidIndexForLists(int Index, int ListSize)
        {
            return (Index >= 0 && Index < ListSize);
        }

        public Boolean HasCueFinished()
        {
            return FinishedCue;
        }

        public void Estop()
        {
            estopped = true;

            for (int i = 0; i < MasterList.Count; i++)
            {
                CurrentCue.GetList()[i].CueMotor.InputData.Control_I3.ControllerInhibit = true;
                MasterList[i].ReadWriteMultipleRegister(8, 0, 4, 12, 4, CurrentCue.GetList()[i].CueMotor.InputData.GetValues(), ref result);
            }

            stopwatch.Stop();
            timer.Stop();
            DisconnectMotors();
            Logger.LogError("EStop was pressed for cue " + CurrentCue.Name);
            Logger.LogInfo("Cue " + CurrentCue.Name + " has stopped running");
        }

        /// <summary>
        /// Create Object representations of Cues, CueItems, and Motors from the associated database
        /// and store the Cues into CueList
        /// </summary>
        public void InitObjects()
        {
            try
            {
                data.connect();

                DataTable CueTable = data.getCues();
                foreach (DataRow CueRow in CueTable.Rows)
                {
                    Cue NewCue = new Cue(CueRow["Name"].ToString(), CueRow["Description"].ToString());
                    DataTable CueItemTable = data.GetAllFromCueMotor(NewCue.Name);
                    foreach (DataRow CueItemRow in CueItemTable.Rows)
                    {
                        Motor CueMotor = new Motor(CueItemRow["IPAddress"].ToString(),
                                                   CueItemRow["MotorName"].ToString(),
                                                   CueItemRow["Description"].ToString(),
                                                   (int)CueItemRow["LimitMaxVelocity"],
                                                   (int)CueItemRow["LimitMaxAcceleration"],
                                                   (int)CueItemRow["LimitMaxDeceleration"],
                                                   (int)CueItemRow["LimitMaxNegPosition"],
                                                   (int)CueItemRow["LimitMaxPosPosition"]);

                        CueItem Item = new CueItem(Double.Parse(CueItemRow["DelayBefore"].ToString()),
                                                   Double.Parse(CueItemRow["RunTime"].ToString()),
                                                   CueMotor,
                                                   (int)CueItemRow["SetVelocity"],
                                                   (int)CueItemRow["SetAcceleration"],
                                                   (int)CueItemRow["SetDeceleration"],
                                                   Convert.ToBoolean(CueItemRow["CounterClockwise"]),
                                                   (int)CueItemRow["SetPosition"]);

                        NewCue.Add(Item);
                    }
                    CueList.Add(NewCue);
                }
                data.disconnect();
                foreach(Cue c in CueList)
                {
                    Console.WriteLine(c.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<Cue> GetCueList()
        {
            return CueList;
        }
        
    }
}

