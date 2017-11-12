using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    public class SetpointValue2 : MotorAction
    {
        private int setpointValue2;

        public SetpointValue2()
        {
            setpointValue2 = 0;
            bool b = new SubcontrolWord().ActivateTorqueLimit;
        }

        public void Set(int setpointValue2)
        {
            this.setpointValue2 = setpointValue2;
        }

        public int Get()
        {
            return setpointValue2;
        }

        // TODO These two encode methods


        public byte EncodeByte0()
        {
            return System.Convert.ToByte(0);
        }

        public byte EncodeByte1()
        {
            return System.Convert.ToByte(0);
        }

    }
}
