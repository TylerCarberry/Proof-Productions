using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{

    public class OutputCurrent : OutputValue
    {
        public OutputCurrent()
        {
            
        }

        public override String ToString()
        {
            return "Output Current \r\n Value: " + Get() + "\r\n";
        }
    }
}
