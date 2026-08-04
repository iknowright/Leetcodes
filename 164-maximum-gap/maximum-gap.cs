public class Solution {
    public int MaximumGap(int[] nums) {
        if(nums.Length==1) return 0;
        Array.Sort(nums);
        int max=0;
        for(int i=1; i<nums.Length; i++) {
            max = Math.Max(max, nums[i]-nums[i-1]);
        }
        return max;
    }
}