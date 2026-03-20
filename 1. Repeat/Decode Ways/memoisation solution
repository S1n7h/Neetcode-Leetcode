public class Solution {
    public int NumDecodings(string s) {
        var memo = new int[s.Length + 1];
        for (int i = 0 ; i < memo.Length ; i++) memo[i] = -1;
        return memoisation(s, s.Length - 1, memo);
    }

    private int memoisation(string s, int idx, int[] memo){
        if (idx == 0){
            if (s[idx] == '0')  {
                memo[idx] = 0;
                return 0;
            }
            else {
                memo[idx] = 1;
                return 1;
            }
        }

        if (idx == -1)  return 1;

        if (memo[idx] != -1) return memo[idx];

        int ways = 0;

        //number is either 10 or 20
        if (s[idx] == '0'){
            if (s[idx - 1] == '1' || s[idx - 1] == '2'){
                memo[idx] = memoisation(s, idx - 2, memo);
                return memo[idx];
            }else{
                memo[idx] = 0;
                return memo[idx];
            }
        }

        
        if (s[idx - 1] == '1' || (s[idx - 1] == '2' && s[idx] <= '6')){
            ways = memoisation(s, idx - 1, memo) + memoisation(s, idx - 2, memo);
        }//look at it as a separate string
        else ways = memoisation(s, idx - 1, memo);
        
        memo[idx] = ways;
        return ways;
    }
}
