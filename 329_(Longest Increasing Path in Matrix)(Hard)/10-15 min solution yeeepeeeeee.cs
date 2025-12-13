public class Solution
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        var dict = new Dictionary<(int, int), int>();

        int ret = 0;
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[0].Length; c++)
            {
                ret = Math.Max(ret, Dfs(matrix, r, c, dict));
            }
        }
        return ret;
    }

    public int Dfs(int[][] matrix, int r, int c, Dictionary<(int, int), int> dict)
    {
        if (dict.ContainsKey((r, c))) return dict[(r, c)];

        int ret = 0;
        if (IsValid(matrix, r, c, r + 1, c))
        {
            ret = Math.Max(ret, Dfs(matrix, r + 1, c, dict));
        }
        if (IsValid(matrix, r, c, r - 1, c))
        {
            ret = Math.Max(ret, Dfs(matrix, r - 1, c, dict));
        }
        if (IsValid(matrix, r, c, r, c + 1))
        {
            ret = Math.Max(ret, Dfs(matrix, r, c + 1, dict));
        }
        if (IsValid(matrix, r, c, r, c - 1))
        {
            ret = Math.Max(ret, Dfs(matrix, r, c - 1, dict));
        }
        dict[(r, c)] = ret + 1;
        return dict[(r, c)];
    }

    public bool IsValid(int[][] matrix, int curr_r, int curr_c, int r, int c)
    {
        if (r >= 0 && c >= 0 && r < matrix.Count() && c < matrix[0].Count() && matrix[curr_r][curr_c] < matrix[r][c]) return true;
        return false;
    }
}
