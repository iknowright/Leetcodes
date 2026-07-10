public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max=0, sum;
        foreach(int[] account in accounts) {
            sum = account.Sum();
            if(max<sum) max = sum;
        }
        return max;
    }
}