public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int max=1, increasing=1, decreasing=1;
        for(int i=1; i<nums.Length; i++) {
            if(nums[i]>nums[i-1]) { increasing++; decreasing=1; }
            else if(nums[i]<nums[i-1]) { increasing=1; decreasing++; }
            else { increasing=1; decreasing=1; }
            max = Math.Max(max, Math.Max(increasing, decreasing));
        }
        return max;
    }
}