public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        int total = mean*(rolls.Length+n)-rolls.Sum(), i=0;

        if(total<n || total > 6*n) return new int[0];

        int[] res = new int[n];
        Array.Fill(res, 1); total-=n;
        while(total>0) {
            res[i++] += Math.Min(5, total);
            total -= Math.Min(5, total);
        }
        return res;
    }
}