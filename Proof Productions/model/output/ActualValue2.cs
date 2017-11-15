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
        private int Value;

        public ActualValue02()
        {

        }

        public void Decode(byte first, byte second, byte third, byte fourth)
        {
            Value = (first * 16777216) + (second * 65536) + (third * 256) + fourth;
        }

        public int Get()
        {
            return Value;
        }
    }
}
