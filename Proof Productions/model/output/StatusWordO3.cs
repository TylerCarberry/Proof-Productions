using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class StatusWordO3 : OutputBoolean
    {
        public bool MotorTurning, InverterReady, Referenced, SetpointValueReached,
                    BrakeReleased, Error_FC, Warning, ErrorApplication;

        public StatusWordO3()
        {

        }

        //TODO - set
    }
}
