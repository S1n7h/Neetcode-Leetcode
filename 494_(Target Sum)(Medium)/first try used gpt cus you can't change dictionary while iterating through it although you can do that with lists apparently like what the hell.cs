public class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        if (nums.Length == 0) return 0;

        if (nums[0] == 0) dict[0] = 2;
        else
        {
            dict[nums[0]] = 1;
            dict[-nums[0]] = 1;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            var next = new Dictionary<int, int>();
            foreach (var item in dict)
            {
                if (!next.ContainsKey(item.Key + nums[i])) next[item.Key + nums[i]] = dict[item.Key];
                else next[item.Key + nums[i]] += dict[item.Key];

                if (!next.ContainsKey(item.Key - nums[i])) next[item.Key - nums[i]] = dict[item.Key];
                else next[item.Key - nums[i]] += dict[item.Key];
            }
            dict = next;
            foreach (var item in dict) Console.Write($"{item.Key} : {item.Value},   ");
            Console.WriteLine();
        }
        if (!dict.ContainsKey(target)) return 0;
        return dict[target];
    }
}