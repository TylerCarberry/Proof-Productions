namespace Proof_Productions.Model.Input
{
    public abstract class InputBoolean
    {
        
        // An InputBoolean is a data type that is an array of booleans to be sent to the motor
        // Each boolean represent a field that could be toggled

        /// <summary>
        /// Convert the object to a byte to be sent to the motor
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        protected byte ConvertBoolArraytoByte(bool[] source)
        {
            byte result = 0;

            int index = 8 - source.Length;
            foreach (bool b in source)
            {
                if (b)
                {
                    // Shift the byte by one to make room for the next bit
                    result |= (byte)(1 << (index));
                }
                index++;
            }
            return result;
        }
        
    }
}
