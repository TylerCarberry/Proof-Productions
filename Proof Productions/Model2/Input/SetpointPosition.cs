using System;

namespace Proof_Productions.Model.Input
{
    public class SetpointPosition : InputBoolean
    {

        private int setpointPosition;
        private byte[] temp;

        public SetpointPosition()
        {
            setpointPosition = 0;
        }

        public void Set(int setpointPosition)
        {
            this.setpointPosition = setpointPosition;
        }

        public int Get()
        {
            return setpointPosition;
        }

        private byte[] ByteConverter()
        {
            return temp = BitConverter.GetBytes(setpointPosition);
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
