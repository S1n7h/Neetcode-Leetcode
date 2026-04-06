public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        Array.Sort(nums);
        Dictionary<int, int> cache = new Dictionary<int, int>();
        return Dfs(nums, cache, 0, target);
    }

    int Dfs(int[] nums, Dictionary<int, int> cache, int curr_sum, int target){
        if (cache.ContainsKey(curr_sum)) return cache[curr_sum];
        if (curr_sum == target) return 1;

        int ret = 0;

        for(int i = 0 ; i < nums.Length ; i++){
            if (curr_sum + nums[i] > target) break;
            ret += Dfs(nums, cache, curr_sum + nums[i], target);
        }

        cache[curr_sum] = ret;
        return ret;
    }
}