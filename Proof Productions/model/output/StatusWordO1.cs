using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class StatusWordO1 : OutputBoolean
    {
        public bool Maintenance_switch, Toggle, Bit02, UserBit, Dataset_exists, Autoreload_config, Warning, Error;
        private int Value;

        public StatusWordO1()
        {

        }

        public void Decode(byte first, byte second)
        {
            Boolean[] data = new Boolean[8];
            data = ConvertByteToBoolArray(second);

            Maintenance_switch = data[0];
            Toggle = data[1];
            Bit02 = data[2];
            UserBit = data[3];
            Dataset_exists = data[4];
            Autoreload_config = data[5];
            Warning = data[6];
            Error = data[7];

            Value = (int)first;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
