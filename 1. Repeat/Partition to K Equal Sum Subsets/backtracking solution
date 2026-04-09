public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        int sum = 0;
        bool[] visited = new bool[nums.Length];
        Array.Fill(visited, false);

        foreach(var num in nums)    sum += num;
        if (sum % k != 0)   return false;

        //reverse sorting of array for pruning
        Array.Sort(nums,(int a, int b) => {return b - a;});

        return Dfs(sum / k, k, nums, visited, 0, 0);
    }

    bool Dfs(int target, int k, int[] nums, bool[] visited, int subsetSum, int start){
        if (k == 0) return true;
        if (subsetSum == target){
            return Dfs(target, k - 1, nums, visited, 0, 0);
        }

        for(int i = start ; i < nums.Length ; i++){
            if (visited[i] == false && subsetSum + nums[i] <= target){
                visited[i] = true;
                if (Dfs(target, k, nums, visited, subsetSum + nums[i], i + 1)) return true;
                visited[i] = false;

                //if it is a new subset, and it can't even return true, it means that,
                //there's no combination of indexes which can be paired with the current index
                //to give a total sum equal to that of target, so there's no point in continuing
                //basically, if the first index that you pick, can't return a sum equal to that of target
                //just return false cus there's no way you will be able to make k subsets then
                if (subsetSum == 0) return false;

                //if sum of current subset sum and current index can't return true in the above Dfs call,
                //it means that even if there were any other instance, where you picked the current index
                //you wouldn't be able to find a result
                //eg:- if subset sum is 5, target is 9, and element at curr index is 4, and given that
                //the above dfs call did not pass, it means that no matter how you choose the remaining available indexes
                //later on, even if they give a result of 5, you still won't be able to return true cus this doesn't return a true
                //in the previous dfs call
                if (subsetSum + nums[i] == target)  return false;
            }
        }return false;
    }
}