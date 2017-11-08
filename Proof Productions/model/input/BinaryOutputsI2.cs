using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model.input
{

    // There are 2 Binary Output fields in the input. One in field 2, one in field 10
    // This class is the bits that correspond to the binary outputs in the second field

    // TODO: Convert this to an array

    class BinaryOutputs_I2
    {
        public bool DO00 { get; set; }
        public bool DO01 { get; set; }
        public bool DO02 { get; set; }
        public bool DO03 { get; set; }
        public bool DO04 { get; set; }
        public bool DO05 { get; set; }
        public bool DO06 { get; set; }
        public bool DO07 { get; set; }
        public bool DO08 { get; set; }
        public bool DO09 { get; set; }
        public bool DO10 { get; set; }
        public bool DO11 { get; set; }
        public bool DO12 { get; set; }
        public bool DO13 { get; set; }
        public bool DO14 { get; set; }
        public bool DO15 { get; set; }

        public BinaryOutputs_I2()
        {

        }

        public int GetSetValue
        {
            get
            {
                return    (2 ^ 0 * (DO00 ? 1 : 0))  | (2 ^ 1 * (DO01 ? 1 : 0)
                        | (2 ^ 2 * (DO02 ? 1 : 0))  | (2 ^ 3 * (DO03 ? 1 : 0))
                        | (2 ^ 4 * (DO04 ? 1 : 0))  | (2 ^ 5 * (DO05 ? 1 : 0))
                        | (2 ^ 6 * (DO06 ? 1 : 0))  | (2 ^ 7 * (DO07 ? 1 : 0))
                        | (2 ^ 8 * (DO08 ? 1 : 0))  | (2 ^ 9 * (DO09 ? 1 : 0))
                        | (2 ^ 10 * (DO10 ? 1 : 0)) | (2 ^ 11 * (DO11 ? 1 : 0))
                        | (2 ^ 12 * (DO12 ? 1 : 0)) | (2 ^ 13 * (DO13 ? 1 : 0))
                        | (2 ^ 14 * (DO14 ? 1 : 0)) | (2 ^ 15 * (DO15 ? 1 : 0)));
            }
            set
            {
                DO00 = (value & 2 ^ 0).Equals(1);
                DO01 = (value & 2 ^ 1).Equals(1);
                DO02 = (value & 2 ^ 2).Equals(1);
                DO03 = (value & 2 ^ 3).Equals(1);
                DO04 = (value & 2 ^ 4).Equals(1);
                DO05 = (value & 2 ^ 5).Equals(1);
                DO06 = (value & 2 ^ 6).Equals(1);
                DO07 = (value & 2 ^ 7).Equals(1);
                DO08 = (value & 2 ^ 8).Equals(1);
                DO09 = (value & 2 ^ 9).Equals(1);
                DO10 = (value & 2 ^ 10).Equals(1);
                DO11 = (value & 2 ^ 11).Equals(1);
                DO12 = (value & 2 ^ 12).Equals(1);
                DO13 = (value & 2 ^ 13).Equals(1);
                DO14 = (value & 2 ^ 14).Equals(1);
                DO15 = (value & 2 ^ 15).Equals(1);
            }
        }
    }
}
