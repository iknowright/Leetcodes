public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum=0, rightSum=nums.Sum();
        for(int i=0; i<nums.Length; i++) {
            rightSum-=nums[i];
            if(leftSum==rightSum) return i;
            leftSum+=nums[i];
        }
        return -1;
    }
}