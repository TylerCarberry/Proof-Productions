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
            ControllerInhibit = WordPart1[0];
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
        /*
        public bool ControllerInhibit { get; set; }
        public bool EnableRapidStart { get; set; } 
        public bool EnableStop { get; set; } 
        public bool Bit3 { get; set; }
        public bool Bit4 { get; set; }
        public bool RelBrake { get; set; }
        public bool ErrorReset { get; set; }
        public bool Bit7 { get; set; }
        public bool Start { get; set; }
        public bool Positive { get; set; } 
        public bool Negative { get; set; }
        public bool Mode2tothe0 { get; set; } 
        public bool Mode2tothe1 { get; set; }
        public bool Mode2tothe2 { get; set; }
        public bool Mode2tothe3 { get; set; }
        public bool SWLS { get; set; }

        //bit  0 : Controller Inhibit
        //bit  1 : Enable Rapid Start

        public long Get()
        {
            return (2 ^ 0 * (ControllerInhibit ? 1 : 0)) | (2 ^ 1 * (EnableRapidStart ? 1 : 0)
                       | (2 ^ 2 * (EnableStop ? 1 : 0)) | (2 ^ 3 * (Bit3 ? 1 : 0))
                       | (2 ^ 4 * (Bit4 ? 1 : 0)) | (2 ^ 5 * (RelBrake ? 1 : 0))
                       | (2 ^ 6 * (ErrorReset ? 1 : 0)) | (2 ^ 7 * (Bit7 ? 1 : 0))
                       | (2 ^ 8 * (Start ? 1 : 0)) | (2 ^ 9 * (Positive ? 1 : 0))
                       | (2 ^ 10 * (Negative ? 1 : 0)) | (2 ^ 11 * (Mode2tothe0 ? 1 : 0))
                       | (2 ^ 12 * (Mode2tothe1 ? 1 : 0)) | (2 ^ 13 * (Mode2tothe2 ? 1 : 0))
                       | (2 ^ 14 * (Mode2tothe3 ? 1 : 0)) | (2 ^ 15 * (SWLS ? 1 : 0)));
        }

        public void Set(long value)
        {
            ControllerInhibit = (value & 2 ^ 0).Equals(1);
            EnableRapidStart = (value & 2 ^ 1).Equals(1);
            EnableStop = (value & 2 ^ 2).Equals(1);
            Bit3 = (value & 2 ^ 3).Equals(1);
            Bit4 = (value & 2 ^ 4).Equals(1);
            RelBrake = (value & 2 ^ 5).Equals(1);
            ErrorReset = (value & 2 ^ 6).Equals(1);
            Bit7 = (value & 2 ^ 7).Equals(1);
            Start = (value & 2 ^ 8).Equals(1);
            Positive = (value & 2 ^ 9).Equals(1);
            Negative = (value & 2 ^ 10).Equals(1);
            Mode2tothe0 = (value & 2 ^ 11).Equals(1);
            Mode2tothe1 = (value & 2 ^ 12).Equals(1);
            Mode2tothe2 = (value & 2 ^ 13).Equals(1);
            Mode2tothe3 = (value & 2 ^ 14).Equals(1);
            SWLS = (value & 2 ^ 15).Equals(1);
        }
        */

    }
}
