using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.model.input
{
    namespace Proof_Productions.model
    {
        class SetpointValue2
        {

            int setpointValue2;

            public SetpointValue2()
            {
                setpointValue2 = 0;
            }

            public void Set(int setpointValue2)
            {
                this.setpointValue2 = setpointValue2;
            }

            public int Get()
            {
                return setpointValue2;
            }

        }
    }

}
