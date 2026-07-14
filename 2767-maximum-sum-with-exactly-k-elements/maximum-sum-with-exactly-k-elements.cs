public class Solution {
    public int MaximizeSum(int[] nums, int k) {
        int max=0, res=0;
        foreach(int num in nums) max=Math.Max(max, num);
        return k*max+ k*(k-1)/2;
    }
}