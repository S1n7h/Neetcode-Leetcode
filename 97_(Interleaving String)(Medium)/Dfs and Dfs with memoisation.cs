public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length) return false;
        var dp = new Dictionary<(int, int), bool>();
        return DfsWithMemo(s1, s2, s3, 0, 0, 0, dp);
    }

    public bool DfsWithMemo(string s1, string s2, string s3, int idxOne, int idxTwo, int idxThree, Dictionary<(int, int), bool> dp)
    {
        if (idxOne + idxTwo == s3.Length) return true;
        if (dp.ContainsKey((idxOne, idxTwo))) return dp[(idxOne, idxTwo)];

        if (idxOne < s1.Length && s1[idxOne] == s3[idxThree])
        {
            if (DfsWithMemo(s1, s2, s3, idxOne + 1, idxTwo, idxThree + 1, dp)) return true;
        }

        if (idxTwo < s2.Length && s2[idxTwo] == s3[idxThree])
        {
            if (DfsWithMemo(s1, s2, s3, idxOne, idxTwo + 1, idxThree + 1, dp)) return true;
        }
        dp[(idxOne, idxTwo)] = false;
        return false;
    }

    // public bool Dfs(string s1, string s2, string s3, int idxOne, int idxTwo, int idxThree){
    //     if (idxOne + idxTwo == s3.Length) return true;

    //     if (idxOne < s1.Length && s1[idxOne] == s3[idxThree]){
    //         if (Dfs(s1, s2, s3, idxOne + 1, idxTwo, idxThree + 1))  return true;
    //     }

    //     if (idxTwo < s2.Length && s2[idxTwo] == s3[idxThree]){
    //         if (Dfs(s1, s2, s3, idxOne, idxTwo + 1, idxThree + 1))  return true;
    //     }
    //     return false;
    // }
}

