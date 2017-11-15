using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public abstract class OutputValue
    {
        private int Value { get; set; }

        public OutputValue()
        {
            Value = 0;
        }

        public void Set(int value)
        {
            this.Value = value;
        }

        public int Get()
        {
            return Value;
        }

        //TODO - not sure if output values need encodebytes
    }
}
