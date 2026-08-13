public class Solution {
    public int[] FinalPrices(int[] prices) {
        int n = prices.Length, j;
        int[] res = new int[n];
        for(int i=0; i<n; i++) {
            res[i] = prices[i];
            j=i+1;
            while(j<n && prices[j]>prices[i]) j++;
            if(j!=n) res[i]-=prices[j];
        }
        return res;
    }
}