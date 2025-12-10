public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 1) return 0;
        var dp = new int[prices.Length + 1, 2];

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            for (int buy = 0; buy < 2; buy++)
            {
                //if buying
                if (buy == 1)
                {
                    int buying = dp[i + 1, 0] - prices[i];
                    int cooldown = dp[i + 1, 1];
                    dp[i, 1] = Math.Max(buying, cooldown);
                }
                else
                {
                    //if selling, you have two options, either you sell today, and then buy 2 days later OR you skip today (cooldown)
                    int sell;
                    if (i + 2 < prices.Length) sell = dp[i + 2, 1] + prices[i];
                    else sell = prices[i];

                    int cooldown = dp[i + 1, 0];

                    dp[i, 0] = Math.Max(sell, cooldown);
                }
            }
        }
        return dp[0, 1];
    }
}
