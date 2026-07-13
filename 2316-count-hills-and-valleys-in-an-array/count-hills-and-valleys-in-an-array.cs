public class Solution {
    public int CountHillValley(int[] nums) {
        int count=0, prev=nums[0];

        for(int i=1; i<nums.Length-1; i++) {
            if(nums[i]==nums[i+1]) continue;
            if(prev<nums[i] && nums[i]>nums[i+1]) count++;
            else if(prev>nums[i] && nums[i]<nums[i+1]) count++;
            prev=nums[i];
        }
        return count;
    }
}