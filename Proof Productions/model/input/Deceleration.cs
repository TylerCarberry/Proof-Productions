namespace Proof_Productions.Model.Input
{

    public class Deceleration : MotorAction
    {

        private int deceleration;

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

        public override byte Encode()
        {
            return System.Convert.ToByte(deceleration);
        }

    }
}
