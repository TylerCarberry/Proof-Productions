using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    class SubcontrolWord
    {
        public bool ActivateTouchProbe { get; set; }
        public bool Bit01 { get; set; }
        public bool ActivateTorqueLimit { get; set; }
        public bool Bit03 { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool Bit06 { get; set; }
        public bool Bit07 { get; set; }

        //bit  0 : Controller Inhibit
        //bit  1 : Enable Rapid Start

        public SubcontrolWord()
        {

        }

        public void Set(int value)
        {
            ActivateTouchProbe = (value & 2 ^ 0).Equals(1);
            Bit01 = (value & 2 ^ 1).Equals(1);
            ActivateTorqueLimit = (value & 2 ^ 2).Equals(1);
            Bit03 = (value & 2 ^ 3).Equals(1);
            Bit04 = (value & 2 ^ 4).Equals(1);
            Bit05 = (value & 2 ^ 5).Equals(1);
            Bit06 = (value & 2 ^ 6).Equals(1);
            Bit07 = (value & 2 ^ 7).Equals(1);
        }

        public int Get()
        {
            return (2 ^ 0 * (ActivateTouchProbe ? 1 : 0)) | (2 ^ 1 * (Bit01 ? 1 : 0)
                       | (2 ^ 2 * (ActivateTorqueLimit ? 1 : 0)) | (2 ^ 3 * (Bit03 ? 1 : 0))
                       | (2 ^ 4 * (Bit04 ? 1 : 0)) | (2 ^ 5 * (Bit05 ? 1 : 0))
                       | (2 ^ 6 * (Bit06 ? 1 : 0)) | (2 ^ 7 * (Bit07 ? 1 : 0)));
        }

    }
}
