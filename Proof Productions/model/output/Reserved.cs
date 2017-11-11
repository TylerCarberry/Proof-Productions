using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{

    class Reserved
    {

        int reserved;

        public Reserved()
        {
            reserved = 0;
        }

        public void Set(int reserved)
        {
            this.reserved = reserved;
        }

        public double Get()
        {
            return reserved;
        }

    }
}
