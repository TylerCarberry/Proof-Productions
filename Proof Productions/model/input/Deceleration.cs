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
