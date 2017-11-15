using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{

    public class Reserved : OutputValue
    {
        public Reserved()
        {

        }

        public override String ToString()
        {
            return "Reserved \n Value: " + Get() + "\n";
        }
    }
}
