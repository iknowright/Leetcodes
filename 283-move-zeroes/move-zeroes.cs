public class Solution {
    public void MoveZeroes(int[] nums) {
        int left=0, right=0;
        for(;right<nums.Length; right++) {
            if(nums[right] !=0) nums[left++] = nums[right];
        }
        for(; left<nums.Length; left++) nums[left] =0;
    }
}