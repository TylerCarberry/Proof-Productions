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
<<<<<<< HEAD
        }

        private byte ConvertBoolArraytoByte(bool[] source)
=======
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
>>>>>>> 1f30a517f6932aec35f51b5c0eca4bee4e31b0db
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

<<<<<<< HEAD
        public byte GetByte0()
=======
        public void Set(long value)
>>>>>>> 1f30a517f6932aec35f51b5c0eca4bee4e31b0db
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
<<<<<<< HEAD

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
=======
        */

>>>>>>> 1f30a517f6932aec35f51b5c0eca4bee4e31b0db
    }
}
