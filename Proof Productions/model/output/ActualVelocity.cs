using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{

    class ActualVelocity
    {

        double actualVelocity;

        public ActualVelocity()
        {
            actualVelocity = 0;
        }

        public void Set(double actualVelocity)
        {
            this.actualVelocity = actualVelocity;
        }

        public double Get()
        {
            return actualVelocity;
        }

    }
}
