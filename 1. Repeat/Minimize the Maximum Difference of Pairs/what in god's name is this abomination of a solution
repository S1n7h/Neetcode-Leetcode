public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        Dictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
        Array.Sort(nums);

        return Dfs(nums, dict, p, 0);
    }

    int Dfs(int[] nums, Dictionary<(int, int), int> dict, int p, int idx){
        if(p == 0)  return 0;
        if (idx >= nums.Length - 1) return int.MaxValue/2;
        if(dict.ContainsKey((idx, p)))  return dict[(idx, p)];

        int take = Math.Max(Math.Abs(nums[idx+1] - nums[idx]), Dfs(nums, dict, p - 1, idx + 2));
        int skip = Dfs(nums, dict, p, idx + 1);
        dict[(idx, p)] = Math.Min(take, skip);
        return dict[(idx, p)];
    }
}