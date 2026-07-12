public class Solution {
    public int BitwiseComplement(int n) {
        if(n==0) return 1;
        int res=0, i=0;
        while(n!=0) {
            if(n%2==0) res+= (int)Math.Pow(2, i);
            n/=2; i++;
        }
        return res;
    }
}