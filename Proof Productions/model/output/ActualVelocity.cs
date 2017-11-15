using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{

    public class ActualVelocity : OutputValue
    {

        public ActualVelocity()
        {

        }

        public override String ToString()
        {
            return "Actual Velocity \n Value: " + Get() + "\n";
        }
    }
}
