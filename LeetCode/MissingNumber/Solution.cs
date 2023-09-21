namespace MissingNumber
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
            }

            for (int i = 0; i <= nums.Length; i++)
            {
                xor = xor ^ i;
            }

            return xor;
        }
    }
}
