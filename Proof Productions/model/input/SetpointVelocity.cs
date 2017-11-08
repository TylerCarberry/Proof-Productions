namespace Proof_Productions.model
{
    class SetpointVelocity
    {

        int setpointVelocity;

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

    }
}
