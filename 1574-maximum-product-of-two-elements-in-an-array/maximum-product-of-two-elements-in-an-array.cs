public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length-1;
        return (nums[n]-1)*(nums[n-1]-1);
    }
}