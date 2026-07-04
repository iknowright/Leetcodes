public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        int last=nums.Length-1, negative, positive;
        negative = nums[0]*nums[1]*nums[last];
        positive = nums[last]*nums[last-1]*nums[last-2];
        return Math.Max(negative, positive);
    }
}