public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int slow=0, fast=0;
        for(int i=0; i<nums.Length; i++) {
            if(nums[i]!=val) {
                nums[slow++]=nums[i];
            }
        }
        return slow;
    }
}