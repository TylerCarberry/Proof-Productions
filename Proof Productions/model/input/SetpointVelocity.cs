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

        public override byte Encode()
        {
            return System.Convert.ToByte(setpointVelocity);
        }

    }
}
