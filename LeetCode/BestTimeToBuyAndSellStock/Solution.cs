namespace BestTimeToBuyAndSellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;

            int left = 0;
            int profit = 0;

            for (int right = 1; right < prices.Length; right++)
            {
                if (prices[right] > prices[left])
                {
                    profit = Math.Max(profit, prices[right] - prices[left]);
                }
                else
                {
                    left = right;
                }
            }

            return profit;
        }
    }
}
