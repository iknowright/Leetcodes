public class Solution {
    public int[] MinCosts(int[] cost) {
        int min = cost[0];
        int[] res = new int[cost.Length];

        for(int i=0; i<cost.Length; i++) {
            min = Math.Min(min, cost[i]);
            res[i]=min;
        }

        return res;
    }
}