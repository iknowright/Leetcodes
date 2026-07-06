public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int a=n/2, b=n-n/2, x=2;
        while(a.ToString().Contains('0') || b.ToString().Contains('0')) {
            x+=1;
            if(b<=n/x) {
                a-=n/x; b+=n/x;
            }
            else {
                a+=n/x; b-=n/x;
            }
        }
        return new int[] {a, b};
    }
}
