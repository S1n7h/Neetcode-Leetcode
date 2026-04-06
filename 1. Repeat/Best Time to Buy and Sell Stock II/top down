public class Solution {
    public int MaxProfit(int[] prices) {
        Dictionary<(int, bool), int> cache = new Dictionary<(int, bool), int>();
        return Dfs(prices, cache, 0, false);
    }

    int Dfs(int[] prices, Dictionary<(int, bool), int> cache, int idx, bool prev_option){
        if (cache.ContainsKey((idx, prev_option))) return  cache[(idx, prev_option)];
        if (idx >= prices.Length) return 0;

        //consider witholding
        int ret = Dfs(prices, cache, idx + 1, prev_option);
        
        //
        if (prev_option == false){
            ret = Math.Max(ret, -prices[idx] + Dfs(prices, cache, idx + 1, true));
        }else {
            ret =  Math.Max(ret, prices[idx] + Dfs(prices, cache, idx + 1, false));
        }

        cache[(idx, prev_option)] = ret;
        return ret;        
    }
}