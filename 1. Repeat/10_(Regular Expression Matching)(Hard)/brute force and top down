public class Solution {
    public bool IsMatch(string s, string p) {
        var memo = new Dictionary<(int, int), bool>();
        return DfsWithMemo(s, p, 0, 0, memo);
    }

    bool Dfs(string s, string p, int i, int j){
        if (i >= s.Length && j >= p.Length) return true;
        if (i < s.Length && j >= p.Length)  return false;

        bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');

        if (j + 1 < p.Length && p[j + 1] == '*'){
            return Dfs(s, p, i, j + 2) || (match && Dfs(s, p, i + 1, j));
        }
        
        if (match) return Dfs(s, p, i + 1, j + 1);
        return false;
    }

    bool DfsWithMemo(string s, string p, int i, int j, Dictionary<(int, int), bool> memo){
        if (i >= s.Length && j >= p.Length) return true;
        if (i < s.Length && j >= p.Length)  return false;
        if (memo.ContainsKey((i, j)))   return memo[(i, j)];

        bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');

        if (j + 1 < p.Length && p[j + 1] == '*'){
            memo[(i, j)] = DfsWithMemo(s, p, i, j + 2, memo) || (match && DfsWithMemo(s, p, i + 1, j, memo));
            return memo[(i, j)];
        }
        
        if (match)  {
            memo[(i, j)] = DfsWithMemo(s, p, i + 1, j + 1, memo);
            return memo[(i, j)];
        }
        memo[(i, j)] = false;
        return memo[(i, j)];
    }
}
