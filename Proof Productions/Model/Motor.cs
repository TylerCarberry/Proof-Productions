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
        public String[] DataRow; //represents a datarow in the table - may move to controller bc bad design
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

        public Motor(String IPAddress, String Name, String Description, PLC ConnectedPLC, 
                     int LimitMaxVelocity, int LimitMaxAcceleration, int LimitMaxDeceleration,
                     int LimitMaxNegPosition, int LimitMaxPosPosition)
        {
            this.IPAddress = IPAddress;
            this.Name = Name;
            this.Description = Description;
            this.ConnectedPLC = ConnectedPLC;
            this.LimitMaxVelocity = LimitMaxVelocity;
            this.LimitMaxAcceleration = LimitMaxAcceleration;
            this.LimitMaxDeceleration = LimitMaxDeceleration;
            this.LimitMaxNegPosition = LimitMaxNegPosition;
            this.LimitMaxPosPosition = LimitMaxPosPosition;
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
