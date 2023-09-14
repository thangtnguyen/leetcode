namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length < 1) return 0;
            if (nums.Length == 1)
            {
                if (nums[0] != val)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            int index = 0;

            foreach (int n in nums)
            {
                if (n != val)
                {
                    nums[index++] = n;
                }
            }
            return index;
        }
    }
}
