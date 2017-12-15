using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model
{
    public class RotationalScaler
    {
        double CountsPerRev;
        int InitialPosition;

        public RotationalScaler(double CountsPerDegree, int InitialPosition)
        {
            CountsPerRev = CountsPerDegree;
            this.InitialPosition = InitialPosition;
        }

        public void SetCountsPerRev(double Counts)
        {
            CountsPerRev = Counts;
        }

        public double GetCountsPerRev()
        {
            return CountsPerRev;
        }

        public void SetInitialPosition(int Position)
        {
            InitialPosition = Position;
        }

        public int GetInitialPosition()
        {
            return InitialPosition;
        }
    }
}
