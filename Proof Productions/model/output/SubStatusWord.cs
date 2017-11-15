using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class SubStatusWord : OutputBoolean
    {
        public bool TouchProbe_active, TouchProbe_detected, Bit02, Bit03, Bit04, Bit05, HWLSpos, HWLSneg;
        private int Value;

        public SubStatusWord()
        {

        }

        public void Decode(byte first, byte second)
        {
            Boolean[] data = new Boolean[8];
            data = ConvertByteToBoolArray(second);

            TouchProbe_active = data[0];
            TouchProbe_detected = data[1];
            Bit02 = data[2];
            Bit03 = data[3];
            Bit04 = data[4];
            Bit05 = data[5];
            HWLSpos = data[6];
            HWLSneg = data[7];

            Value = (int)first;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
