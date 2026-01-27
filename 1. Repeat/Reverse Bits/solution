public class Solution {
    public uint ReverseBits(uint n) {
        int l = 31 , r = 0;
        uint ret = 0;
        for(int i = 0 ; i < 32 ; i++){
            uint bit = (n >> i) & 1;
            ret += (bit << 31 - i); 
        }
        return ret;
    }
}
