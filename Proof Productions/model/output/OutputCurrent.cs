using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model
{

    class OutputCurrent
    {

        int outputCurrent;

        public OutputCurrent()
        {
            outputCurrent = 0;
        }

        public void Set(int outputCurrent)
        {
            this.outputCurrent = outputCurrent;
        }

        public int Get()
        {
            return outputCurrent;
        }

    }
}
