using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model.output
{
    class BinaryInputsO10
    {
        public bool DI00 { get; set; }
        public bool DI01 { get; set; }
        public bool DI02 { get; set; }
        public bool DI03 { get; set; }
        public bool DI04 { get; set; }
        public bool DI05 { get; set; }
        public bool DI06 { get; set; }
        public bool DI07 { get; set; }
        public bool DI10 { get; set; }
        public bool DI11 { get; set; }
        public bool DI12 { get; set; }
        public bool DI13 { get; set; }
        public bool DI14 { get; set; }
        public bool DI15 { get; set; }
        public bool DI16 { get; set; }
        public bool DI17 { get; set; }

        public BinaryInputsO10()
        {

        }

        public int Get()
        {
            return (2 ^ 0 * (DI00 ? 1 : 0)) | (2 ^ 1 * (DI01 ? 1 : 0)
                    | (2 ^ 2 * (DI02 ? 1 : 0)) | (2 ^ 3 * (DI03 ? 1 : 0))
                    | (2 ^ 4 * (DI04 ? 1 : 0)) | (2 ^ 5 * (DI05 ? 1 : 0))
                    | (2 ^ 6 * (DI06 ? 1 : 0)) | (2 ^ 7 * (DI07 ? 1 : 0))
                    | (2 ^ 8 * (DI10 ? 1 : 0)) | (2 ^ 9 * (DI11 ? 1 : 0))
                    | (2 ^ 10 * (DI12 ? 1 : 0)) | (2 ^ 11 * (DI13 ? 1 : 0))
                    | (2 ^ 12 * (DI14 ? 1 : 0)) | (2 ^ 13 * (DI15 ? 1 : 0))
                    | (2 ^ 14 * (DI16 ? 1 : 0)) | (2 ^ 15 * (DI17 ? 1 : 0)));
        }

        public void Set(int value)
        {
            DI00 = (value & 2 ^ 0).Equals(1);
            DI01 = (value & 2 ^ 1).Equals(1);
            DI02 = (value & 2 ^ 2).Equals(1);
            DI03 = (value & 2 ^ 3).Equals(1);
            DI04 = (value & 2 ^ 4).Equals(1);
            DI05 = (value & 2 ^ 5).Equals(1);
            DI06 = (value & 2 ^ 6).Equals(1);
            DI07 = (value & 2 ^ 7).Equals(1);
            DI10 = (value & 2 ^ 8).Equals(1);
            DI11 = (value & 2 ^ 9).Equals(1);
            DI12 = (value & 2 ^ 10).Equals(1);
            DI13 = (value & 2 ^ 11).Equals(1);
            DI14 = (value & 2 ^ 12).Equals(1);
            DI15 = (value & 2 ^ 13).Equals(1);
            DI16 = (value & 2 ^ 14).Equals(1);
            DI17 = (value & 2 ^ 15).Equals(1);
        }
    }
}
