namespace RemoveDuplidatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length <= 1) return nums.Length;

            int index = 0;
            int lastValue = nums[index];
            foreach (int x in nums)
            {
                if (x != lastValue)
                {
                    nums[++index] = x;
                    lastValue = nums[index];
                }
            }

            return index + 1;
        }
    }
}
