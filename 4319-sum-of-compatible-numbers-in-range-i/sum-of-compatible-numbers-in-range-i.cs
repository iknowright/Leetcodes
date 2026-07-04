public class Solution {
    public int SumOfGoodIntegers(int n, int k) {
        int sum=0;
        for(int i=Math.Max(0, n-k); i<=n+k; i++) {
            if((n&i)==0) sum+=i;
        }
        return sum;
    }
}