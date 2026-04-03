public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int sum = matchsticks.Sum();
        if (sum % 4 != 0) return false;
        if (matchsticks.Length < 4) return false;

        return backtracking(matchsticks, 0, 0, 0, 0, 0, sum/4);
    }

    bool backtracking(int[] matchsticks, int idx, int u, int r, int b, int l, int length){
        if (u > length || r > length || b > length || l > length)   return false;
        if (idx >= matchsticks.Length){
            if (u == r && r == b && b == l && l == u)   return true;
            else return false;
        }    

        return (backtracking(matchsticks, idx + 1, u + matchsticks[idx], r, b, l, length) ||
                backtracking(matchsticks, idx + 1, u, r + matchsticks[idx], b, l, length) ||
                backtracking(matchsticks, idx + 1, u, r, b + matchsticks[idx], l, length) ||
                backtracking(matchsticks, idx + 1, u, r, b, l + matchsticks[idx], length));
    }
}