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
        public String IPAddress, Name, Description;
        public PLC ConnectedPLC;
        FieldbusInputData InputData;
        FieldbusOutputData OutputData;

        //TODO Implement Motor Limits
        public int LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition;

        public Motor(String IPAddress, String Name, String Description, PLC ConnectedPLC)
        {
            this.IPAddress = IPAddress;
            this.Name = Name;
            this.Description = Description;
            this.ConnectedPLC = ConnectedPLC;
        }




    }
}
