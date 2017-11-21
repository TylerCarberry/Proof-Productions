using System;

namespace Proof_Productions.Model.Input
{
    // There are 2 Control Word fields in the input. One in field 1, one in field 3
    // This class is the bits that correspond to the binary outputs in the third field
    public class ControlWordI3 : InputBoolean
    {
        // First byte
        public Boolean ControllerInhibit { get; set; }
        public Boolean EnableRapidStart { get; set; }
        public Boolean EnableStop { get; set; }
        public Boolean Bit3 { get; set; }
        public Boolean Bit4 { get; set; }
        public Boolean RelBrake { get; set; }
        public Boolean ErrorReset { get; set; }
        public Boolean Bit7 { get; set; }

        // Second byte
        public Boolean Start { get; set; }
        public Boolean Positive { get; set; }
        public Boolean Negative { get; set; }
        public Boolean Mode2tothe0 { get; set; }
        public Boolean Mode2tothe1 { get; set; }
        public Boolean Mode2tothe2 { get; set; }
        public Boolean Mode2tothe3 { get; set; }
        public Boolean SWLS { get; set; }

        public ControlWordI3()
        {
            EnableRapidStart = true;
            EnableStop = true;
            Negative = true;
            Mode2tothe0 = true;
        }
        
        public byte EncodeByte0()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = ControllerInhibit;
            wordArray[1] = EnableRapidStart;
            wordArray[2] = EnableStop;
            wordArray[3] = Bit3;
            wordArray[4] = Bit4;
            wordArray[5] = RelBrake;
            wordArray[6] = ErrorReset;
            wordArray[7] = Bit7;
            return ConvertBoolArraytoByte(wordArray);
        }

        public byte EncodeByte1()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = Start;
            wordArray[1] = Positive;
            wordArray[2] = Negative;
            wordArray[3] = Mode2tothe0;
            wordArray[4] = Mode2tothe1;
            wordArray[5] = Mode2tothe2;
            wordArray[6] = Mode2tothe3;
            wordArray[7] = SWLS;
            return ConvertBoolArraytoByte(wordArray);
        }


    }
}
