using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    // There are 2 Control Word fields in the input. One in field 1, one in field 3
    // This class is the bits that correspond to the binary outputs in the first field
    public class ControlWord_I1 : MotorAction
    {
        //bit  0 : Controller Inhibit
        //bit  1 : Enable Rapid Start

        public Boolean[] WordPart1 = new Boolean[8];
        public Boolean[] WordPart2 = new Boolean[8];

        public Boolean Download_Dataset, Upload_Dataset, Upload_Dataset_And_Autoreload, Simulation_Mode_Off, Auto_Configuration_Off, Bit05, Reboot_System, Bit07;
        public Boolean Bit08, Bit09, Bit10, Bit11, Bit12, Bit13, UserBit1, UserBit2;

        public ControlWord_I1() { }
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
            WordPart1[0] = Download_Dataset;
            WordPart1[1] = Upload_Dataset;
            WordPart1[2] = Upload_Dataset_And_Autoreload;
            WordPart1[3] = Simulation_Mode_Off;
            WordPart1[4] = Auto_Configuration_Off;
            WordPart1[5] = Bit05;
            WordPart1[6] = Reboot_System;
            WordPart1[7] = Bit07;
            return ConvertBoolArraytoByte(WordPart1);
        }

        public byte GetByte1()
        {
            WordPart2[0] = Bit08;
            WordPart2[1] = Bit09;
            WordPart2[2] = Bit10;
            WordPart2[3] = Bit11;
            WordPart2[4] = Bit12;
            WordPart2[5] = Bit13;
            WordPart2[6] = UserBit1;
            WordPart2[7] = UserBit2;
            return ConvertBoolArraytoByte(WordPart2);
        }

        // TODO
        public override byte Encode()
        {
            return System.Convert.ToByte(0);
        }
    }
}
