namespace Proof_Productions.Model.Input
{

    class Deceleration
    {

        int deceleration;

        public Deceleration()
        {
            deceleration = 0;
        }

        public void Set(int deceleration)
        {
            this.deceleration = deceleration;
        }

        public int Get()
        {
            return deceleration;
        }

    }
}
