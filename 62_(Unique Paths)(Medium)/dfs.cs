public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int ret = 0;
        var dict = new Dictionary<(int, int), bool>();

        Dfs(0, 0, m, n, ref ret, ref dict);
        return ret;
    }

    void Dfs(int r, int c, int m, int n, ref int ret, ref Dictionary<(int, int), bool> dict)
    {
        if (r == m - 1 && c == n - 1)
        {
            ret++;
            return;
        }
        if (dict.ContainsKey((r, c))) return;

        dict[(r, c)] = true;
        //down
        if (isValid(r + 1, c, m, n, ref dict))
        {
            Dfs(r + 1, c, m, n, ref ret, ref dict);
        }
        // if(isValid(r - 1, c, m, n, ref dict)){
        //     Dfs(r - 1, c, m, n, ref ret, ref dict);
        // } 
        if (isValid(r, c + 1, m, n, ref dict))
        {
            Dfs(r, c + 1, m, n, ref ret, ref dict);
        }
        // if(isValid(r, c - 1, m, n, ref dict)){
        //     Dfs(r, c - 1, m, n, ref ret, ref dict);
        // }
        dict.Remove((r, c));
        return;
    }
    bool isValid(int r, int c, int m, int n, ref Dictionary<(int, int), bool> dict)
    {
        //check within bounds
        if (c >= 0 && r >= 0 && r <= m - 1 && c <= n - 1)
        {
            if (dict.ContainsKey((r, c))) return false;
            else return true;
        }
        return false;
    }
}
