public class Solution {
    public int[] ConcatWithReverse(int[] nums) {
        int[] res = new int[2*nums.Length];
        for(int i=0; i<nums.Length; i++) res[i]=nums[i];
        for(int i=nums.Length-1; i>=0; i--) res[2*nums.Length-i-1]=nums[i];
        return res;
    }
}