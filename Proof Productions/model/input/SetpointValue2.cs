using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    public class SetpointValue2 : InputBoolean
    {
        private int setpointValue2;
        private byte[] temp;

        public SetpointValue2()
        {
            setpointValue2 = 0;
            bool b = new SubcontrolWord().ActivateTorqueLimit;
        }

        public void Set(int setpointValue2)
        {
            this.setpointValue2 = setpointValue2;
        }

        public int Get()
        {
            return setpointValue2;
        }

        private byte[] ByteConverter()
        {
            return temp = BitConverter.GetBytes(setpointValue2);
        }

        public byte EncodeByte0()
        {
            return temp[0];
        }

        public byte EncodeByte1()
        {
            return temp[1];
        }

        public byte EncodeByte2()
        {
            return temp[2];
        }

        public byte EncodeByte3()
        {
            //When the packets are formed, EncodeByte3 is called first because the bits are flipped.
            return ByteConverter()[3];
        }
    }
}
