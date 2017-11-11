using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{

    // There are 2 Binary Output fields in the input. One in field 2, one in field 10
    // This class is the bits that correspond to the binary outputs in the second field

    // TODO: Convert this to an array

    class BinaryOutputs_I10
    {
        public Boolean[] WordPart1 = new Boolean[8];
        public Boolean[] WordPart2 = new Boolean[8];

        public Boolean DO00, DO01, DO02, DO03, DO04, DO05, DO06, DO07;
        public Boolean DO10, DO11, DO12, DO13, DO14, DO15, DO16, DO17;

        private byte ConvertBoolArraytoByte(bool[] source)
        {
            byte result = 0;

            int index = 8 - source.Length;
            foreach (bool b in source)
            {
                if (b)
                    result |= (byte)(1 << (index));
                index++;
            }
            return result;
        }

        public byte GetByte0()
        {
            WordPart1[0] = DO00;
            WordPart1[1] = DO01;
            WordPart1[2] = DO02;
            WordPart1[3] = DO03;
            WordPart1[4] = DO04;
            WordPart1[5] = DO05;
            WordPart1[6] = DO06;
            WordPart1[7] = DO07;            
            return ConvertBoolArraytoByte(WordPart1);
        }

        public byte GetByte1()
        {
            WordPart2[0] = DO10;
            WordPart2[1] = DO11;
            WordPart2[2] = DO12;
            WordPart2[3] = DO13;
            WordPart2[4] = DO14;
            WordPart2[5] = DO15;
            WordPart2[6] = DO16;
            WordPart2[7] = DO17;
            return ConvertBoolArraytoByte(WordPart2);
        }
    }
}
