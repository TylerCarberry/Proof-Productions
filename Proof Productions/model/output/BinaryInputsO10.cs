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
        
       /**Takes in two bytes and sets the corresponding booleans 
        * based on which bits are on 
        */
        public void Decode(byte first, byte second)
        {
            Boolean[] data = new Boolean[8];
            data = ConvertByteToBoolArray(second);
            DI00 = data[0];
            DI01 = data[1];
            DI02 = data[2];
            DI03 = data[3];
            DI04 = data[4];
            DI05 = data[5];
            DI06 = data[6];
            DI07 = data[7];

            data = ConvertByteToBoolArray(first);
            DI10 = data[0];
            DI11 = data[1];
            DI12 = data[2];
            DI13 = data[3];
            DI14 = data[4];
            DI15 = data[5];
            DI16 = data[6];
            DI17 = data[7];
        }
    }
}
