using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proof_Productions.Model.Input;
using Proof_Productions.Model.Output;

namespace Proof_Productions.Model
{
    class Motor
    {
        String IPAddress, Name, Description;
        PLC ConnectedPLC;
        FieldbusInputData InputData;
        FieldbusOutputData OutputData;

        //TODO Implement Motor Limits
        int LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition;

        public Motor(String IPAddress, String Name, String Description, PLC ConnectedPLC)
        {
            this.IPAddress = IPAddress;
            this.Name = Name;
            this.Description = Description;
            this.ConnectedPLC = ConnectedPLC;
        }




    }
}
