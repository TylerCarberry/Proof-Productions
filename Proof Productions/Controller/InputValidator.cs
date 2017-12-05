using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Controller
{
    public class InputValidator
    {

        //This method will be used to ensure that the data that
        //will be entered into the Velocity text box is a number
        //and does not go outside of predetermined boundaries
        public static Boolean IsValidVelocity(String input)
        {
            int v;
            if (int.TryParse(input, out v))
            {
                return v >= 0 && v <= 1750;
            }
            return false;
        }

        //This method will be used to ensure that the data that
        //will be entered into the Acceleration text box is a number
        //and does not go outside of predetermined boundaries
        public static Boolean IsValidAcceleration(String input)
        {
            int a;
            if(int.TryParse(input, out a))
            {
                return a >= 0 && a <= 1750;
            }
            return false;
        }

        //This method will be used to ensure that the data that 
        //will be entered into the Position text box is a number
        public static Boolean IsValidPosition(String input)
        {
            int num;
            return int.TryParse(input, out num);
        }
        
    }
}
