using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{ 
    // There are 2 Control Word fields in the input. One in field 1, one in field 3
    // This class is the bits that correspond to the binary outputs in the third field
    public class ControlWord_I3
    {
        public Boolean[] WordPart1 = new Boolean[8];
        public Boolean[] WordPart2 = new Boolean[8];

        public Boolean ControllerInhibit, EnableRapidStart, EnableStop, Bit3, Bit4, RelBrake, ErrorReset, Bit7;
        public Boolean Start, Positive, Negative, Mode2tothe0, Mode2tothe1, Mode2tothe2, Mode2tothe3, SWLS;

        public ControlWord_I3()
        {
        }

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
            WordPart1[0] = ControllerInhibit;
            WordPart1[1] = EnableRapidStart;
            WordPart1[2] = EnableStop;
            WordPart1[3] = Bit3;
            WordPart1[4] = Bit4;
            WordPart1[5] = RelBrake;
            WordPart1[6] = ErrorReset;
            WordPart1[7] = Bit7;
            return ConvertBoolArraytoByte(WordPart1);
        }

        public byte GetByte1()
        {
            WordPart2[0] = Start;
            WordPart2[1] = Positive;
            WordPart2[2] = Negative;
            WordPart2[3] = Mode2tothe0;
            WordPart2[4] = Mode2tothe1;
            WordPart2[5] = Mode2tothe2;
            WordPart2[6] = Mode2tothe3;
            WordPart2[7] = SWLS;
            return ConvertBoolArraytoByte(WordPart2);
        }
    }
}
