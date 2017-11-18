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
        private int Value;
        public ActualPosition()
        {
           
        }

        public void Decode(byte first, byte second, byte third, byte fourth)
        {
            Value = (((sbyte)first) << 24) + ((second) << 16) + ((third) << 8) + (fourth);
            Value = (int)(Value * 0.1);
            //Console.WriteLine(Value);
        }

        public int Get()
        {
            return Value;
        }

        public override String ToString()
        {
            return "Actual Position \r\n Value: " + Value + "\r\n";
        }

    }
}
