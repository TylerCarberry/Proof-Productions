namespace Proof_Productions.Model.Input
{
    class Acceleration
    { 
        int acceleration;

        public Acceleration()
        {
            acceleration = 0;
        }

        public void Set(int acceleration)
        {
            this.acceleration = acceleration;
        }

        public int Get()
        {
            return acceleration;
        }

    }
}
