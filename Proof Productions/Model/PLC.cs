using System;

namespace Proof_Productions.Model
{
    public class PLC
    {
        public String Name;
        public String IP_Address;
        
        //TODO Figure out and create methods and variables for a PLC
        public PLC()
        {
            Name = "Default PLC";
        }

        public PLC(String Name, String IP_Address)
        {
            this.Name = Name;
            this.IP_Address = IP_Address;
        }
    }
}
