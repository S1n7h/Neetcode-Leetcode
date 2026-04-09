public class Solution {
    public int IntegerBreak(int n) {
        Dictionary<int, int> cache = new Dictionary<int, int>();
        int Dfs(int num){
            if (cache.ContainsKey(num)) return cache[num];
            if (num == 1)   return 1;

            int ret = num == n ? 0 : num;
            for(int i = 1 ; i < num ; i++){
                ret = Math.Max(ret, (Dfs(i) * Dfs(num - i)));
            }
            cache[num] = ret;
            return ret;
        }
        return Dfs(n);
    }
}