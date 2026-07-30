public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int res=0, n;
        Dictionary<int, int> counts=new();
        foreach(int num in nums) {
            counts[num] = counts.GetValueOrDefault(num)+1;
        }
        foreach(var count in counts) {
            n=count.Value;
            res+= n*(n-1)/2;
        }
        return res;
    }
}