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

        public override byte Encode()
        {
            return System.Convert.ToByte(setpointPosition);
        }

    }
}
