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

        public override byte Encode()
        {
            return System.Convert.ToByte(Accel);
        }

    }
}
