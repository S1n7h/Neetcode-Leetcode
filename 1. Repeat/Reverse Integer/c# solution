public class Solution {
    public int Reverse(int x) {
        bool IsPositive = true;
        if (x < 0)  {
            IsPositive = false;
            x *= -1;
        }

        int ret = 0;
        while(x > 0){
            if (ret < int.MinValue / 10 || ret > int.MaxValue / 10) return 0;
            ret = ret * 10 + x % 10;
            x = x / 10;
        }
        
        if (!IsPositive)
            return -1 * ret;
        return ret;
    }
}
