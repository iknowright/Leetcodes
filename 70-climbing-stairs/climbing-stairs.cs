public class Solution {
    public int ClimbStairs(int n) {
        if(n is 1) return 1;
        int a=1, b=2,c;
        for(int i=3; i<=n; i++) {
            c=a+b;
            a=b;
            b=c;
        }
        return b;
    }
}