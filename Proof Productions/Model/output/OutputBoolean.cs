using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public abstract class OutputBoolean
    {
        //TODO - make this into convert byte to bool array
        protected byte ConvertBoolArraytoByte(bool[] source)
        {
            byte result = 0;

            int index = 8 - source.Length;
            foreach (bool b in source)
            {
                if (b)
                {
                    result |= (byte)(1 << (index));
                }
                index++;
            }
            return result;
        }

    }
}
