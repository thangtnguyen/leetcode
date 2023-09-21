namespace ReserseBits
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint reserve = 0;
            for (int i = 1; i <= 32; i++)
            {
                reserve = reserve << 1;
                reserve = reserve | (1 & n);
                n = n >> 1;
            }

            return reserve;
        }
    }
}
