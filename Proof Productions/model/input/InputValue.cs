using System;

namespace Proof_Productions.Model.Input
{
    public abstract class InputValue
    {
        // An InputValue is a simple integer class with a setter, getter, and encode

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

        // Encode the first byte of the value
        public byte EncodeByte0()
        {
            return BitConverter.GetBytes(Value)[0];
        }

        // Encode the second bit of the value
        public byte EncodeByte1()
        {
            return BitConverter.GetBytes(Value)[1];
        }
    }
}
