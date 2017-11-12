namespace Proof_Productions.Model.Input
{
    public class SetpointPosition : MotorAction
    {

        private int setpointPosition;

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
