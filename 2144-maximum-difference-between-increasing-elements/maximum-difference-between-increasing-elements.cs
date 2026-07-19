public class Solution {
    public int MaximumDifference(int[] nums) {
        int max = -1, min = nums[0];
        for(int i=1; i<nums.Length; i++) {
            if(nums[i]!=min) max=Math.Max(max, nums[i]-min);
            min = Math.Min(nums[i], min);
        }
        return max;
    }
}