public class Solution {
    public void SortColors(int[] nums) {
        int[] arr = new int[3] {0, 0, 0};
        foreach(var num in nums)    arr[num]++;
        int idx = 0;
        for(int i = 0 ; i < nums.Count() ; i++){
            while (arr[idx] == 0)  idx++;
            nums[i] = idx;
            arr[idx]--;
        }
    }
}