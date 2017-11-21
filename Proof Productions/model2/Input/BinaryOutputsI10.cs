using System;

namespace Proof_Productions.Model.Input
{

    // There are 2 Binary Output fields in the input. One in field 2, one in field 10
    // This class is the bits that correspond to the binary outputs in the second field

    public class BinaryOutputsI10 : InputBoolean
    {

        // First byte
        public Boolean DO00, DO01, DO02, DO03, DO04, DO05, DO06, DO07;

        // Second byte
        public Boolean DO10, DO11, DO12, DO13, DO14, DO15, DO16, DO17;


        public byte EncodeByte0()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = DO00;
            wordArray[1] = DO01;
            wordArray[2] = DO02;
            wordArray[3] = DO03;
            wordArray[4] = DO04;
            wordArray[5] = DO05;
            wordArray[6] = DO06;
            wordArray[7] = DO07;
            return ConvertBoolArraytoByte(wordArray);
        }

        public byte EncodeByte1()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = DO10;
            wordArray[1] = DO11;
            wordArray[2] = DO12;
            wordArray[3] = DO13;
            wordArray[4] = DO14;
            wordArray[5] = DO15;
            wordArray[6] = DO16;
            wordArray[7] = DO17;
            return ConvertBoolArraytoByte(wordArray);
        }

    }
}
