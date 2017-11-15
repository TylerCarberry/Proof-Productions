using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class BinaryInputsO10 : OutputBoolean
    {
        //It is unknown what DIXX corresponds to 
        //First byte
        public bool DI00, DI01, DI02, DI03, DI04, DI05, DI06, DI07;

        //Second byte
        public bool DI10, DI11, DI12, DI13, DI14, DI15, DI16, DI17;

        public BinaryInputsO10()
        {

        }

       //TODO - implement Decode method
       /**Takes in two bytes and sets the corresponding booleans 
        * based on which bits are on 
        */
        public void Set(byte first, byte second)
        {

        }
    }
}
