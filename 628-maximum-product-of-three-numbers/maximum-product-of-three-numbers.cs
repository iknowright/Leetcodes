public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        int negatives = nums[0]*nums[1]*nums[n-1];
        int positives = nums[n-1]*nums[n-2]*nums[n-3];
        return Math.Max(negatives, positives);
    }
}