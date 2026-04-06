public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        Dictionary<int, int> cache = new Dictionary<int, int>();

        foreach(var str in dictionary)   dict[str] = 1;

        return Dfs(s, dict, cache, 0);
    }

    int Dfs(string s, Dictionary<string, int> dict, Dictionary<int, int> cache, int idx){
        if (cache.ContainsKey(idx)) return cache[idx];

        if (idx >= s.Length)    return 0;

        //skip current character
        int ret = 1 + Dfs(s, dict, cache, idx + 1);

        //check all substrings including current character
        for(int j = idx ; j < s.Length ; j++){
            //if dict contains said substring, traverse the dfs to find smallest return value
            if (dict.ContainsKey(s.Substring(idx, j - idx + 1)))    
                ret = Math.Min(ret, Dfs(s, dict, cache, j + 1));
        }

        cache[idx] = ret;
        return ret;
    }
}