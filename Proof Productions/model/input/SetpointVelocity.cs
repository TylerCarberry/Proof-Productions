using System;

namespace Proof_Productions.Model.Input
{
    public class SetpointVelocity : MotorAction
    {

        private int setpointVelocity;

        public SetpointVelocity()
        {
            setpointVelocity = 0;
        }

        public void Set(int setpointVelocity)
        {
            this.setpointVelocity = setpointVelocity;
        }

        public int Get()
        {
            return setpointVelocity;
        }

        public byte EncodeByte0()
        {
            return BitConverter.GetBytes(setpointVelocity)[0];
        }

        public byte EncodeByte1()
        {
            return BitConverter.GetBytes(setpointVelocity)[1];
        }


    }
}
