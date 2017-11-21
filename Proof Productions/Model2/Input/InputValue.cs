using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    public abstract class InputValue
    {
        private int Value { get; set; }

        public InputValue()
        {
            Value = 0;
        }

        public void Set(int value)
        {
            Value = value;
        }

        public int Get()
        {
            return Value;
        }

        public byte EncodeByte0()
        {
            return BitConverter.GetBytes(Value)[0];
        }

        public byte EncodeByte1()
        {
            return BitConverter.GetBytes(Value)[1];
        }
    }
}
