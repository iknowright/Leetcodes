public class Solution {
    public int MaxProductDifference(int[] nums) {
        Array.Sort(nums);
        int len = nums.Length-1;
        return nums[len]*nums[len-1] - nums[0]*nums[1];
    }
}