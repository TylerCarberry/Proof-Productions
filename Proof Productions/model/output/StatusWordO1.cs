using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class StatusWordO1 : OutputBoolean
    {
        public bool Maintenance_switch, Toggle, Bit02, UserBit,
                    Dataset_exists, Autoreload_config, Warning, Error;

        public StatusWordO1()
        {

        }
        
        //TODO - Do decode
    }
}
