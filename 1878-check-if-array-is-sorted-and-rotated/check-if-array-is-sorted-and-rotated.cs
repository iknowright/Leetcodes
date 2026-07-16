public class Solution {
    public bool Check(int[] nums) {
        int drop=0;
        for(int i=0; i<nums.Length-1; i++) {
            if(nums[i]>nums[i+1]) drop++;
        }
        if(drop is 0) return true;
        else if(drop is 1) return nums[0]>=nums[nums.Length-1];
        else return false;
    }
}