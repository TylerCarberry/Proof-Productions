using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    class StatusWordO3
    {
        public bool MotorTurning { get; set; }
        public bool InverterReady { get; set; }
        public bool Referenced { get; set; }
        public bool SetpointValueReached { get; set; }
        public bool BrakeReleased { get; set; }
        public bool Error_FC { get; set; }
        public bool Warning { get; set; }
        public bool ErrorApplication { get; set; }

        public StatusWordO3()
        {

        }

        public int Get()
        {
            return (2 ^ 0 * (MotorTurning ? 1 : 0)) | (2 ^ 1 * (InverterReady ? 1 : 0)
                        | (2 ^ 2 * (Referenced ? 1 : 0)) | (2 ^ 3 * (SetpointValueReached ? 1 : 0))
                        | (2 ^ 4 * (BrakeReleased ? 1 : 0)) | (2 ^ 5 * (Error_FC ? 1 : 0))
                        | (2 ^ 6 * (Warning ? 1 : 0)) | (2 ^ 7 * (ErrorApplication ? 1 : 0)));
        }

        public void Set(int value)
        {
            MotorTurning = (value & 2 ^ 0).Equals(1);
            InverterReady = (value & 2 ^ 1).Equals(1);
            Referenced = (value & 2 ^ 2).Equals(1);
            SetpointValueReached = (value & 2 ^ 3).Equals(1);
            BrakeReleased = (value & 2 ^ 4).Equals(1);
            Error_FC = (value & 2 ^ 5).Equals(1);
            Warning = (value & 2 ^ 6).Equals(1);
            ErrorApplication = (value & 2 ^ 7).Equals(1);
        }

    }
}
