public class Solution
{
    public int NumDistinct(string s, string t)
    {
        var dict = new Dictionary<(int, int), int>();
        return DfsWithMemo(0, 0, dict, s, t);
    }
    private int DfsWithMemo(int i, int j, Dictionary<(int, int), int> dict, string s, string t)
    {
        if (j == t.Length) return 1;
        if (i == s.Length) return 0;

        if (dict.ContainsKey((i, j))) return dict[(i, j)];

        int ret = 0;
        if (s[i] == t[j]) ret = DfsWithMemo(i + 1, j, dict, s, t) + DfsWithMemo(i + 1, j + 1, dict, s, t);

        else ret = DfsWithMemo(i + 1, j, dict, s, t);

        dict[(i, j)] = ret;
        return ret;
    }
}
