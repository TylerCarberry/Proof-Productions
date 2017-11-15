using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    //Does not extend the OutputBoolean class as it is a special case with a high word and a low word
    public class ActualPosition
    {
        private long Value;
        public ActualPosition()
        {
           
        }

        public void Decode(byte first, byte second, byte third, byte fourth)
        {
            Value = (fourth * 16777216) + (third * 65536) + (second * 256) + first;
        }

        public long Get()
        {
            return Value;
        }

        public override String ToString()
        {
            return "Actual Position \n Value: " + Value + "\n";
        }

    }
}
