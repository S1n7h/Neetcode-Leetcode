public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        for(int r = m - 1 ; r >= 0 ; r--){
            for(int c = n - 1 ; c >= 0 ; c--){
                if (r == m - 1 && c == n - 1)   continue;
                //bottom most array, leaving the bottom-right position
                if (r == m - 1 && c < n - 1){
                    grid[r][c] += grid[r][c + 1];
                }
                //all coordinates at the rightmost column, except the bottom-right position
                else if (r < m - 1 && c == n - 1) {
                    grid[r][c] += grid[r + 1][c];
                }
                else{
                    grid[r][c] += Math.Min(grid[r + 1][c], grid[r][c + 1]);
                }
            }
        }
        return grid[0][0];
    }
}