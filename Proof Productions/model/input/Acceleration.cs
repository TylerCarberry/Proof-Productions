namespace Proof_Productions.Model.Input
{
    public class Acceleration : MotorAction
    {
        private int Accel { get; set; }

        public Acceleration()
        {
            Accel = 0;
        }

        public void Set(int acceleration)
        {
            this.Accel = acceleration;
        }

        public int Get()
        {
            return Accel;
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
