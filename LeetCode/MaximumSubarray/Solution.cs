namespace MaximumSubarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int currentSubMax = nums[0];
            int maxSum = nums[0];
            
            for (int i = 1; i < nums.Length; i++)
            {
                currentSubMax = Math.Max(currentSubMax + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, currentSubMax);
            }

            return maxSum;
        }
    }
}
