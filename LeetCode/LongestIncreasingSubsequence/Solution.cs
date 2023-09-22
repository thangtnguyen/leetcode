namespace LongestIncreasingSubsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            if (n == 1) return 1;
            int[] dp = new int[n];
            dp[0] = 1;
            int result = 0;
            for (int i = 1; i < n; i++)
            {
                int len = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i]) 
                    {
                        len = Math.Max(len, dp[j]);
                    }
                }
                dp[i] = len + 1;
                result = Math.Max(result, dp[i]);
            }

            return result;
        }
    }
}
