using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class SubStatusWord : OutputBoolean
    {
        public bool TouchProbe_active, TouchProbe_detected, Bit02, 
                    Bit03, Bit04, Bit05, HWLSpos, HWLSneg;

        public SubStatusWord()
        {

        }

        //TODO - decode
    }
}
