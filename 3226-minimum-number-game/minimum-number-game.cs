public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        int temp;
        for(int i=0; i<nums.Length; i+=2) {
            temp = nums[i];
            nums[i] = nums[i+1];
            nums[i+1] = temp;
        }
        return nums;
    }
}