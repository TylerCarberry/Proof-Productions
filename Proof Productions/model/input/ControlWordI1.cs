using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    // There are 2 Control Word fields in the input. One in field 1, one in field 3
    // This class is the bits that correspond to the binary outputs in the first field
    public class ControlWordI1 : MotorAction
    {
        // First byte
        public Boolean Download_Dataset;
        public Boolean Upload_Dataset;
        public Boolean Upload_Dataset_And_Autoreload;
        public Boolean Simulation_Mode_Off;
        public Boolean Auto_Configuration_Off;
        public Boolean Bit05;
        public Boolean Reboot_System;
        public Boolean Bit07;

        // Second byte
        public Boolean Bit08;
        public Boolean Bit09;
        public Boolean Bit10;
        public Boolean Bit11;
        public Boolean Bit12;
        public Boolean Bit13;
        public Boolean UserBit1;
        public Boolean UserBit2;

        public ControlWordI1() { }

        public byte EncodeByte0()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = Download_Dataset;
            wordArray[1] = Upload_Dataset;
            wordArray[2] = Upload_Dataset_And_Autoreload;
            wordArray[3] = Simulation_Mode_Off;
            wordArray[4] = Auto_Configuration_Off;
            wordArray[5] = Bit05;
            wordArray[6] = Reboot_System;
            wordArray[7] = Bit07;
            return ConvertBoolArraytoByte(wordArray);
        }

        public byte EncodeByte1()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = Bit08;
            wordArray[1] = Bit09;
            wordArray[2] = Bit10;
            wordArray[3] = Bit11;
            wordArray[4] = Bit12;
            wordArray[5] = Bit13;
            wordArray[6] = UserBit1;
            wordArray[7] = UserBit2;
            return ConvertBoolArraytoByte(wordArray);
        }

    }
}
