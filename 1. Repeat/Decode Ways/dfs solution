public class Solution {
    public int NumDecodings(string s) {
        var memo = new int[s.Length + 1];
        return memoisation(s, s.Length - 1, memo);
    }

    private int memoisation(string s, int idx, int[] memo){
        if (idx == 0){
            if (s[idx] == '0')  return 0;
            else return 1;
        }

        if (idx == -1)  return 1;

        int ways = 0;

        //number is either 10 or 20
        if (s[idx] == '0'){
            if (s[idx - 1] == '1' || s[idx - 1] == '2'){
            return memoisation(s, idx - 2, memo);
            }else return 0;
        }

        
        if (s[idx - 1] == '1' || (s[idx - 1] == '2' && s[idx] <= '6')){
            ways = memoisation(s, idx - 1, memo) + memoisation(s, idx - 2, memo);
        }//look at it as a separate string
        else ways = memoisation(s, idx - 1, memo);
        
        return ways;
    }
}
