namespace Proof_Productions.Model.Input
{
    public abstract class InputBoolean
    {
        
        protected byte ConvertBoolArraytoByte(bool[] source)
        {
            byte result = 0;

            int index = 8 - source.Length;
            foreach (bool b in source)
            {
                if (b)
                {
                    result |= (byte)(1 << (index));
                }
                index++;
            }
            return result;
        }
        
    }
}
