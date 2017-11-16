using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    //Does not extend OutputValue as it is a special case with a high word and a low word
    public class ActualValue02
    {
        private long Value;

        public ActualValue02()
        {

        }

        public void Decode(byte first, byte second, byte third, byte fourth)
        {
            Value = (first * 256 * 256 * 256) + (second * 256 * 256) + (third * 256) + fourth;
        }

        public long Get()
        {
            return Value;
        }

        public override String ToString()
        {
            return "Actual Value2 \r\n Value: " + Value + "\r\n";
        }
    }
}
