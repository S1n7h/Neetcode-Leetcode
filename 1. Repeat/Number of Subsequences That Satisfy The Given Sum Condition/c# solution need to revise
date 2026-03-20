public class Solution {
    public int NumSubseq(int[] nums, int target) {
        long ret = 0;
        int mod = 1000000007;
        Array.Sort(nums);

        int l = 0, r = nums.Length - 1;

        long[] power = new long[nums.Length];
        power[0] = 1;
        for (int i = 1; i < nums.Length; i++) {
            power[i] = (power[i - 1] * 2) % mod;
        }

        while (l <= r){
            if (nums[l] + nums[r] <= target){
                ret = (ret + power[r - l]) % mod;
                l++;
            }else r--;
        }
        return (int)ret;
    }
}