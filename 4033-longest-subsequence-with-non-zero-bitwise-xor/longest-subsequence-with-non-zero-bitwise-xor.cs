public class Solution {
    public int LongestSubsequence(int[] nums) {
        int xor=0;
        bool nonzero=false;
        foreach(int num in nums) {
            xor ^= num;
            nonzero |= num!=0;
        }
        if(xor !=0) return nums.Length;
        return nonzero? nums.Length-1: 0;
    }
}