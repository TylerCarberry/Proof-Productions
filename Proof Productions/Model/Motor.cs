using System;
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
        RotationalScaler Scaler;

        //TODO Implement Motor Limits
        public int LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition;

        public Motor()
        {
            // The default IP address of the motor in the lab
            IPAddress = "192.168.10.4";
            Name = "POC Motor";
            Description = "Default constructor only used for testing and proof of concept purposes only";
        }

        public Motor(String IPAddress, String Name, String Description)
        {
            this.IPAddress = IPAddress;
            this.Name = Name;
            this.Description = Description;
        }

        public Motor(String IPAddress, String Name, String Description, 
                     int LimitMaxVelocity, int LimitMaxAcceleration, int LimitMaxDeceleration,
                     int LimitMaxNegPosition, int LimitMaxPosPosition)
        {
            this.IPAddress = IPAddress;
            this.Name = Name;
            this.Description = Description;
            this.LimitMaxVelocity = LimitMaxVelocity;
            this.LimitMaxAcceleration = LimitMaxAcceleration;
            this.LimitMaxDeceleration = LimitMaxDeceleration;
            this.LimitMaxNegPosition = LimitMaxNegPosition;
            this.LimitMaxPosPosition = LimitMaxPosPosition;
        }

        public void AddScaler(RotationalScaler Scale)
        {
            Scaler = Scale;
        }

        public RotationalScaler GetScaler()
        {
            return Scaler;
        }

        public bool HasScaler()
        {
            if (Scaler == null)
                return false;
            return true;
        }

        /// <summary>
        /// Simple hashcode function
        /// </summary>
        /// <returns> Integer representation of the hashcode </returns>
        public override int GetHashCode()
        {
            int hashcode = IPAddress.GetHashCode() + Name.GetHashCode() +
                           LimitMaxVelocity + LimitMaxAcceleration + LimitMaxDeceleration +
                           LimitMaxNegPosition + LimitMaxPosPosition;
            return hashcode;
        }
    }
}
