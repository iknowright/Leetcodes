public class Solution {
    public bool CanJump(int[] nums) {
        int target = nums.Length-1;
        for(int i=nums.Length-2; i>=0; i--) {
            if(nums[i]+i>=target) {
                target=i;
            }
        } 
        return target==0;
    }
}