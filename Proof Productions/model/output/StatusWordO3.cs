using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class StatusWordO3 : OutputBoolean
    {
        public bool MotorTurning, InverterReady, Referenced, SetpointValueReached, BrakeReleased, Error_FC, Warning, ErrorApplication;
        private int Value;

        public StatusWordO3()
        {

        }

        public void Decode(byte first, byte second)
        {
            Boolean[] data = new Boolean[8];
            data = ConvertByteToBoolArray(second);

            MotorTurning = data[0];
            InverterReady = data[1];
            Referenced = data[2];
            SetpointValueReached = data[3];
            BrakeReleased = data[4];
            Error_FC = data[5];
            Warning = data[6];
            ErrorApplication = data[7];

            Value = (int)first;
        }

        public int GetValue()
        {
            return Value;
        }

        public override String ToString()
        {
            String Debug = "StatusWordO3 \n";
            Debug += "MotorTurning: " + MotorTurning + " InverterReady: " + InverterReady + " Referenced: " + Referenced + " SetpointValueReached: " + SetpointValueReached
                  +  " BrakeReleased: " + BrakeReleased + " Error_FC: " + Error_FC + " Warning: " + Warning + " ErrorApplication: " + ErrorApplication + "\n"
                  +  "Value " +Value + "\n";
            return Debug;
        }
    }
}
