public class Solution {
    public int MinimumCost(int[] nums) {
        int first=nums[1], second=nums[2], temp;
        for(int i=3; i<nums.Length; i++) {
            if(nums[i]<first) {
                temp=first;
                first=nums[i];
                second=Math.Min(temp, second);
            }
            else second=Math.Min(nums[i], second);
        }
        return nums[0]+first+second;
    }
}