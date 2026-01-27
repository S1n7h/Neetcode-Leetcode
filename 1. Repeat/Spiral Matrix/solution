public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        var ret = new List<int>();
        int top = 0, bottom = matrix.Length;
        int left = 0, right = matrix[0].Length;

        while(ret.Count < matrix.Length * matrix[0].Length)
        {
            for (int i = left ; i < right ; i++)
            {
                ret.Add(matrix[top][i]);
            }top++;

            for (int i = top ; i < bottom ; i++)
            {
                ret.Add(matrix[i][right - 1]);
            }right--;

            if (left >= right || top >= bottom)   return ret;

            for (int i = right  - 1; i >= left ; i--)
            {
                ret.Add(matrix[bottom - 1][i]);
            }bottom--; 

            for (int i = bottom - 1; i >= top ; i--)
            {
                ret.Add(matrix[i][left]);
            }left++;         
        }
        return ret;
    }
}