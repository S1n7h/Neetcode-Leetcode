public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var arr = new int[text1.Length + 1][];
        for (int i = 0; i < arr.Count(); i++)
        {
            arr[i] = new int[text2.Length + 1];
        }

        for (int r = text1.Length - 1; r >= 0; r--)
        {
            for (int c = text2.Length - 1; c >= 0; c--)
            {
                if (text1[r] == text2[c]) arr[r][c] = 1 + arr[r + 1][c + 1];
                else arr[r][c] = Math.Max(arr[r + 1][c], arr[r][c + 1]);
            }
        }
        return arr[0][0];
    }
}
