public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        if (days.Length == 1)   return costs.Min();
        Dictionary<int, int> cache = new Dictionary<int, int>();

        return Dfs(days, costs, cache, 0, 0);
    }

    int Dfs(int[] days, int[] costs, Dictionary<int, int> cache, int idx, int cost){
        if (idx >= days.Length) return 0;
        if (cache.ContainsKey(idx)) return cache[idx];

        //(idx, cost) => idx is the current index you are at (which isn't paid for, the last index before it has been paid for)
        //cost is the cost of the previous ticket which was used

        int cost1 = costs[0];
        int cost2 = costs[1];
        int cost3 = costs[2];

        int idx1 = idx + 1, idx2 = idx, idx3 = idx;

        while(idx2 < days.Length && days[idx2] < days[idx] + 7)    idx2++;
        while(idx3 < days.Length && days[idx3] < days[idx] + 30)    idx3++;

        int ret = Math.Min(cost1 + Dfs(days, costs, cache, idx1, cost1), 
                Math.Min(cost2 + Dfs(days, costs, cache, idx2, cost2), cost3 + Dfs(days, costs, cache, idx3, cost3)));

        cache[idx] = ret;
        return ret;
    }
}