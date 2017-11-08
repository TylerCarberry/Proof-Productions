using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model.output
{
    class SubStatusWord
    {
        public bool TouchProbe_active { get; set; }
        public bool TouchProbe_detected { get; set; }
        public bool Bit02 { get; set; }
        public bool Bit03 { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool HWLSpos { get; set; }
        public bool HWLSneg { get; set; }

        public SubStatusWord()
        {

        }

        public int GetSetValue
        {
            get
            {
                return (2 ^ 0 * (TouchProbe_active ? 1 : 0)) | (2 ^ 1 * (TouchProbe_detected ? 1 : 0)
                        | (2 ^ 2 * (Bit02 ? 1 : 0)) | (2 ^ 3 * (Bit03 ? 1 : 0))
                        | (2 ^ 4 * (Bit04 ? 1 : 0)) | (2 ^ 5 * (Bit05 ? 1 : 0))
                        | (2 ^ 6 * (HWLSpos ? 1 : 0)) | (2 ^ 7 * (HWLSneg ? 1 : 0)));
            }
            set
            {
                TouchProbe_active = (value & 2 ^ 0).Equals(1);
                TouchProbe_detected = (value & 2 ^ 1).Equals(1);
                Bit03 = (value & 2 ^ 2).Equals(1);
                Bit03 = (value & 2 ^ 3).Equals(1);
                Bit04 = (value & 2 ^ 4).Equals(1);
                Bit05 = (value & 2 ^ 5).Equals(1);
                HWLSpos = (value & 2 ^ 6).Equals(1);
                HWLSneg = (value & 2 ^ 7).Equals(1);
            }
        }
    }
}
