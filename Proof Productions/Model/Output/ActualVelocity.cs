using System;

namespace Proof_Productions.Model.Output
{

    public class ActualVelocity : OutputValue
    {

        public ActualVelocity()
        {

        }

        public override String ToString()
        {
            return "Actual Velocity \r\n Value: " + Get() + "\r\n";
        }
    }
}
