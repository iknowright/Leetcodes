public class Solution {
    public bool IsGood(int[] nums) {
        if(nums.Length<2) return false;
        Array.Sort(nums);
        for(int i=0; i<nums.Length-1; i++) {
            if(nums[i]!=i+1) return false;
        }
        return nums[nums.Length-1]==nums[nums.Length-2];
    }
}