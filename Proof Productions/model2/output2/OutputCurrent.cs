using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{

    public class OutputCurrent
    {
        double Value;

        public OutputCurrent()
        {
            Value = 0;
        }

        public void Decode(byte first, byte second)
        {
            //May need to cast first and second as ints
            /*
            double d1 = Convert.ToDouble(((sbyte)first));
            double d2 =  (((0x40 & second) == 0x40 ? 1 : 0) * .5 +
                         ((0x20 & second) == 0x20 ? 1 : 0)  * .25 +
                         ((0x10 & second) == 0x10 ? 1 : 0)  * .125 +
                         ((0x08 & second) == 0x8 ? 1 : 0)   * .0625 +
                         ((0x04 & second) == 0x4 ? 1 : 0)   * .03125 +
                         ((0x02 & second) == 0x2 ? 1 : 0)   * .015625 +
                         ((0x01 & second) == 0x1 ? 1 : 0)   * .0078125);
            if ((0x80 & second) == 0x80)
                d2 *= -1;
            double sum = d1 + d2;
            Console.WriteLine(d1 + " " + d2 + " sum: " + sum);
            */
            if (first == 0xFF)
                Value = ((sbyte)second) * 0.1;
            else
                Value = second * 0.1;
        }

        public double Get()
        {
            return Value;
        }

        public override String ToString()
        {
            return "Output Current \r\n Value: " + Get() + "\r\n";
        }
    }
}
