namespace CoinChange
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 0;
            for (int i = 1; i <= amount; i++) 
            {
                int min = int.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i && dp[i - coins[j]] != -1)
                    {
                        min = Math.Min(min, dp[i - coins[j]]);
                    }
                }
                dp[i] = (min == int.MaxValue) ? -1 : min + 1;
            }

            return dp[amount];
        }
    }
}
