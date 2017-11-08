using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model.input
{
    // There are 2 Control Word fields in the input. One in field 1, one in field 3
    // This class is the bits that correspond to the binary outputs in the first field
    class ControlWord_I1
    {
        public ControlWord_I1()
        {

        }


        public bool Download_Dataset { get; set; }
        public bool Upload_Dataset { get; set; }
        public bool Upload_Dataset_And_Autoreload { get; set; }
        public bool Simulation_Mode_Off { get; set; }
        public bool Auto_Configuration_Off { get; set; }
        public bool Bit05 { get; set; }
        public bool Reboot_System { get; set; }
        public bool Bit07 { get; set; }
        public bool Bit08 { get; set; }
        public bool Bit09 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool UserBit1 { get; set; }
        public bool UserBit2 { get; set; }

        //bit  0 : Controller Inhibit
        //bit  1 : Enable Rapid Start

        public int GetSetValue
        {
            get
            {
                return (2 ^ 0 * (Download_Dataset ? 1 : 0)) | (2 ^ 1 * (Upload_Dataset ? 1 : 0)
                        | (2 ^ 2 * (Upload_Dataset_And_Autoreload ? 1 : 0)) | (2 ^ 3 * (Simulation_Mode_Off ? 1 : 0))
                        | (2 ^ 4 * (Auto_Configuration_Off ? 1 : 0)) | (2 ^ 5 * (Bit05 ? 1 : 0))
                        | (2 ^ 6 * (Reboot_System ? 1 : 0)) | (2 ^ 7 * (Bit07 ? 1 : 0))
                        | (2 ^ 8 * (Bit08 ? 1 : 0)) | (2 ^ 9 * (Bit09 ? 1 : 0))
                        | (2 ^ 10 * (Bit10 ? 1 : 0)) | (2 ^ 11 * (Bit11 ? 1 : 0))
                        | (2 ^ 12 * (Bit12 ? 1 : 0)) | (2 ^ 13 * (Bit13 ? 1 : 0))
                        | (2 ^ 14 * (UserBit1 ? 1 : 0)) | (2 ^ 15 * (UserBit2 ? 1 : 0)));
            }
            set
            {
                Download_Dataset = (value & 2 ^ 0).Equals(1);
                Upload_Dataset = (value & 2 ^ 1).Equals(1);
                Upload_Dataset_And_Autoreload = (value & 2 ^ 2).Equals(1);
                Simulation_Mode_Off = (value & 2 ^ 3).Equals(1);
                Auto_Configuration_Off = (value & 2 ^ 4).Equals(1);
                Bit05 = (value & 2 ^ 5).Equals(1);
                Reboot_System = (value & 2 ^ 6).Equals(1);
                Bit07 = (value & 2 ^ 7).Equals(1);
                Bit08 = (value & 2 ^ 8).Equals(1);
                Bit09 = (value & 2 ^ 9).Equals(1);
                Bit10 = (value & 2 ^ 10).Equals(1);
                Bit11 = (value & 2 ^ 11).Equals(1);
                Bit12 = (value & 2 ^ 12).Equals(1);
                Bit13 = (value & 2 ^ 13).Equals(1);
                UserBit1 = (value & 2 ^ 14).Equals(1);
                UserBit2 = (value & 2 ^ 15).Equals(1);
            }
        }
    }
}
