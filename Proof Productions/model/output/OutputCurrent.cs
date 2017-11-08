using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model
{

    class OutputCurrent
    {

        double outputCurrent;

        public OutputCurrent()
        {
            outputCurrent = 0;
        }

        public void Set(double outputCurrent)
        {
            this.outputCurrent = outputCurrent;
        }

        public double Get()
        {
            return outputCurrent;
        }

    }
}
