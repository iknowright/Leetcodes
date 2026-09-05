public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        int n = nums.Length, max=int.MinValue;
        int[] min = new int[n];

        min[n-1] = nums[n-1];
        for(int i=n-2; i>=0; i--) {
            min[i] = Math.Min(nums[i], min[i+1]);
        }
        for(int i=0; i<n; i++) {
            max = Math.Max(max, nums[i]);
            if(max-min[i] <= k) return i;
        }
        return -1;
    }
}