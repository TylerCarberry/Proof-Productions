﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model
{
    public class PLC
    {
        public String Name;
        //TODO Figure out and create methods and variables for a PLC
        public PLC()
        {
            Name = "Default PLC";
        }
        public PLC(String Name)
        {
            this.Name = Name;
        }
    }
}
