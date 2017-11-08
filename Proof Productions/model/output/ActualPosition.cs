using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model
{

    class ActualPosition
    {

        double actualPosition;

        public ActualPosition()
        {
            actualPosition = 0;
        }

        public void Set(double actualPosition)
        {
            this.actualPosition = actualPosition;
        }

        public double Get()
        {
            return actualPosition;
        }

    }
}
