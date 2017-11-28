﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proof_Productions.Model.Input;
using Proof_Productions.Model.Output;

namespace Proof_Productions.Model
{
    public class Motor
    {
        public String IPAddress, Name = "DefaultMotor", Description;
        public PLC ConnectedPLC;
        public FieldbusInputData InputData = new FieldbusInputData();
        public FieldbusOutputData OutputData = new FieldbusOutputData();
        public RotationalScaler Scaler;

        //TODO Implement Motor Limits
        public int LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition;

        public Motor()
        {
            IPAddress = "192.168.10.4";
            Name = "POC Motor";
            Description = "Default constructor only used for testing and proof of concept purposes only";
        }

        public Motor(String IPAddress, String Name, String Description, PLC ConnectedPLC)
        {
            this.IPAddress = IPAddress;
            this.Name = Name;
            this.Description = Description;
            this.ConnectedPLC = ConnectedPLC;
            Scaler = new RotationalScaler(this);
        }

    }
}
