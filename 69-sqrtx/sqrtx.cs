public class Solution {
    public int MySqrt(int x) {
        if(x is 0) return x;
        for(int i=2; i<=x/2; i++) {
            if(i==x/i) return i;
            else if(i>x/i) return i-1;
        }
        return 1;
    }
}