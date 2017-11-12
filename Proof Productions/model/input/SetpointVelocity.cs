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

        // TODO These two encode methods


        public byte EncodeByte0()
        {
            return System.Convert.ToByte(0);
        }

        public byte EncodeByte1()
        {
            return System.Convert.ToByte(0);
        }


    }
}
