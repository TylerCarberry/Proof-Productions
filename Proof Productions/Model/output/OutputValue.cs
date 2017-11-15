using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public abstract class OutputValue
    {
        private int Value;

        public OutputValue()
        {
            Value = 0;
        }

        public void Decode(byte first, byte second)
        {
            //May need to cast first and second as ints
            Value = (256 * (int)second) + (int)first;
        }

        public int Get()
        {
            return Value;
        }

        //TODO - not sure if output values need encodebytes
    }
}
