public class Solution {
    public bool CheckGoodInteger(int n) {
        int square=0, sum=0;
        while(n>0) {
            sum+=n%10;
            square+=(n%10)*(n%10);
            n/=10;
        }
        return square-sum >=50;
    }
}