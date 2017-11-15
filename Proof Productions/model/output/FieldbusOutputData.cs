using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class FieldbusOutputData
    {
        public StatusWordO1 Status_O1;
        public BinaryInputsO2 Binary_O2;
        public StatusWordO3 Status_O3;
        public ActualVelocity ActualVelocity;
        public OutputCurrent OutputCurrent;
        public Reserved Reserved;
        public ActualPosition Actual_Position;
        public SubStatusWord substatusWord;
        public BinaryInputsO10 BinaryInputs_O10;
        public ActualValue02 actualValue2;

    
        //Need one giant decode method

        /**
        public byte[] GetValue
        {
            get
            {
                byte[] bytes = new byte[12];
                //when we return the setpoint velocity, acceleration and deceleration
                //make sure you swap the bytes
                bytes[0] = BitConverter.GetBytes(Status_O1.Get())[0];
                bytes[1] = BitConverter.GetBytes(Status_O1.Get())[1];
                bytes[2] = BitConverter.GetBytes(Binary_O2.Get())[0];
                bytes[3] = BitConverter.GetBytes(Binary_O2.Get())[1];
                bytes[4] = BitConverter.GetBytes(Status_O3.Get())[0];
                bytes[5] = BitConverter.GetBytes(Status_O3.Get())[1];
                bytes[6] = BitConverter.GetBytes(ActualVelocity.Get())[1];
                bytes[7] = BitConverter.GetBytes(ActualVelocity.Get())[0];
                bytes[8] = BitConverter.GetBytes(OutputCurrent.Get())[1];
                bytes[9] = BitConverter.GetBytes(OutputCurrent.Get())[0];
                bytes[10] = BitConverter.GetBytes(Reserved.Get())[1];
                bytes[11] = BitConverter.GetBytes(Reserved.Get())[0];
                bytes[12] = BitConverter.GetBytes(Actual_Position.Get())[1];
                bytes[13] = BitConverter.GetBytes(Actual_Position.Get())[0];
                bytes[14] = BitConverter.GetBytes(substatusWord.Get())[0];
                bytes[15] = BitConverter.GetBytes(substatusWord.Get())[1];
                bytes[16] = BitConverter.GetBytes(BinaryInputs_O10.Get())[0];
                bytes[18] = BitConverter.GetBytes(BinaryInputs_O10.Get())[1];
                bytes[19] = BitConverter.GetBytes(actualValue2.Get())[1];
                bytes[20] = BitConverter.GetBytes(actualValue2.Get())[0];
                //bytes[6] = BitConverter.GetBytes(ActualVelocity.Get())[0];
                //TODO - Continue this for the remainder of the data
                return bytes;
            }
        }
        */
    }
}
