using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class BinaryInputsO2 : OutputBoolean
    {
        //It is unknown what DIXX corresponds to
        //First byte
        public bool DI00, DI01, DI02, DI03, DI04, DI05, DI06, DI07;

        //Second byte
        public bool DI08, DI09, DI10, DI11, DI12, DI13, DI14, DI15;

        public BinaryInputsO2()
        {

        }
       
    }
}
