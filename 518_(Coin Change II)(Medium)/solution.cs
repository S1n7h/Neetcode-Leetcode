public class Solution
{
    public int Change(int amount, int[] coins)
    {
        if (amount == 0) return 1;
        int[,] dp = new int[coins.Length, amount + 1];
        for (int r = 0; r < coins.Length; r++)
        {
            for (int c = 0; c < coins.Length; c++)
            {
                dp[r, c] = 0;
            }
        }
        //NOTE:- ALTHOUGH the ALGORITHM is similar to neetcode's solution, the arrangement of the columns is the opposite
        //because you can't have the 0 index at the rightmost point of a row ,unless ofcourse, the size of the row is 1.
        //although the dp has been made, you are going to have to access the
        //values of the coins using the row index of the dp
        //so, to access 2 in [1, 2, 3], you need to set r = 1; and amount = coins[r];
        for (int r = coins.Length - 1; r >= 0; r--)
        {
            for (int c = amount - 1; c >= 0; c--)
            {
                //index of row is indexes of coins
                int coinValue = coins[r];
                if (c + coinValue < amount + 1)
                {
                    if (c + coinValue == amount) dp[r, c] = 1;
                    else dp[r, c] += dp[r, c + coinValue];
                }
                if (r + 1 < coins.Length) dp[r, c] += dp[r + 1, c];
            }
        }
        for (int r = 0; r < coins.Length; r++)
        {
            for (int c = 0; c < coins.Length; c++)
            {
                Console.Write($"{dp[r, c]}  ");
            }
            Console.WriteLine();
        }
        return dp[0, 0];
    }
}
