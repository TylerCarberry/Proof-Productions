using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model.input
{

    // There are 2 Control Word fields in the input. One in field 1, one in field 3
    // This class is the bits that correspond to the binary outputs in the third field
    public class ControlWord_I3
    {


        public ControlWord_I3()
        {

        }


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

        public int Get()
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

        public void Set(int value)
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


    }
}
