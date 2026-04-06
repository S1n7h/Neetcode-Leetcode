public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[,] dp = new int[n + 1, 2];

        for (int i = n - 1; i >= 0; i--) {
            dp[i, 0] = Math.Max(dp[i + 1, 0], -prices[i] + dp[i + 1, 1]);
            dp[i, 1] = Math.Max(dp[i + 1, 1], prices[i] + dp[i + 1, 0]);
        }

        return dp[0, 0];
    }
}