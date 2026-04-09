public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int [,] dp = new int[n + 1, m + 1];
        for(int i = 0 ; i < n + 1 ; i++){
            for(int j = 0 ; j < m + 1 ; j++){
                //-1 denotes unvisited coordinate
                if (i == n || j == m || matrix[i][j] == '0')    dp[i,j] = 0;
                else dp[i,j] = -1;
            }
        }
        int ret = 0;
        for(int r = 0 ;  r < n ; r++){
            for(int c = 0 ; c < m ; c++){
                ret = Math.Max(ret, Dfs(matrix, dp, r, c));
            }
        }
        return ret * ret;
    }

    int Dfs(char[][] matrix, int [,] dp, int r, int c){
        //if current coordinate is either 0 or visited, return 0 or however much is stored in dp
        if (dp[r, c] != -1) return dp[r, c];

        int bottom = Dfs(matrix, dp, r + 1, c);
        int right = Dfs(matrix, dp, r, c + 1);
        int diagonal = Dfs(matrix, dp, r + 1, c + 1);

        int min = Math.Min(right, Math.Min(bottom, diagonal));
        if (min == 0)   dp[r, c] = 1;
        else dp[r, c] = min + 1;

        return dp[r, c];
    }
}

//dfs at every point
    //check validity(also check for 0), if invalid, return 0 
    //if visited, return whatever stored at that point

    //go to all three paths, store them in three diff variables.
        //take minimum of all those variables. 
            //if minimum is 0, then store 1 at current position in dp
            //else, store minimimum + current value in matrix (not dp) 
            //return either of the results after storing at dp