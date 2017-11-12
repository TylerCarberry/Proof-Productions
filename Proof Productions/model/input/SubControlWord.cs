using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    public class SubcontrolWord : MotorAction
    {
        public bool ActivateTouchProbe { get; set; }
        public bool Bit01 { get; set; }
        public bool ActivateTorqueLimit { get; set; }
        public bool Bit03 { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool Bit06 { get; set; }
        public bool Bit07 { get; set; }

        public SubcontrolWord()
        {

        }

        public byte EncodeByte0()
        {
            Boolean[] wordArray = new Boolean[8];
            wordArray[0] = ActivateTouchProbe;
            wordArray[1] = Bit01;
            wordArray[2] = ActivateTorqueLimit;
            wordArray[3] = Bit03;
            wordArray[4] = Bit04;
            wordArray[5] = Bit05;
            wordArray[6] = Bit06;
            wordArray[7] = Bit07;
            return ConvertBoolArraytoByte(wordArray);
        }

    }
}
