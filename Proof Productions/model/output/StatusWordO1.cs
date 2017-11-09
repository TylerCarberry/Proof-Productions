using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    class StatusWordO1
    {
        public bool Maintenance_switch { get; set; }
        public bool Toggle { get; set; }
        public bool Bit02 { get; set; }
        public bool UserBit { get; set; }
        public bool Dataset_exists { get; set; }
        public bool Autoreload_config { get; set; }
        public bool Warning { get; set; }
        public bool Error { get; set; }

        public StatusWordO1()
        {

        }

        public int Get()
        {
            return (2 ^ 0 * (Maintenance_switch ? 1 : 0)) | (2 ^ 1 * (Toggle ? 1 : 0)
                        | (2 ^ 2 * (Bit02 ? 1 : 0)) | (2 ^ 3 * (UserBit ? 1 : 0))
                        | (2 ^ 4 * (Dataset_exists ? 1 : 0)) | (2 ^ 5 * (Autoreload_config ? 1 : 0))
                        | (2 ^ 6 * (Warning ? 1 : 0)) | (2 ^ 7 * (Error ? 1 : 0)));
        }


        public void Set(int value)
        {
            Maintenance_switch = (value & 2 ^ 0).Equals(1);
            Toggle = (value & 2 ^ 1).Equals(1);
            Bit02 = (value & 2 ^ 2).Equals(1);
            UserBit = (value & 2 ^ 3).Equals(1);
            Dataset_exists = (value & 2 ^ 4).Equals(1);
            Autoreload_config = (value & 2 ^ 5).Equals(1);
            Warning = (value & 2 ^ 6).Equals(1);
            Error = (value & 2 ^ 7).Equals(1);
        }
        
    }
}
