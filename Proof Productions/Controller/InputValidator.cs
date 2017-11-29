using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Controller
{
    public class InputValidator
    {

        //This method will be used to ensure that the data 
        //that will be entered into the Velocity text box
        //does not go outside of predetermined boundaries
        public static Boolean IsValidVelocity(String input)
        {
            int v = int.Parse(input);
            return v >= 0 && v < 100000;
        }

        //This method will be used to ensure that the data 
        //that will be entered into the Aceleration text box
        //does not go outside of predetermined boundaries
        public static Boolean IsValidAcceleration(String input)
        {
            int a = int.Parse(input);
            return a >= 0 && a < 100000;
        }

        //This method will be used to ensure that the data 
        //that will be entered into the Position text box
        //does not go outside of predetermined boundaries
        public static Boolean IsValidPosition(String input)
        {
            int r = int.Parse(input);
            return r >= 0 && r < 100000;
        }
        
    }
}
