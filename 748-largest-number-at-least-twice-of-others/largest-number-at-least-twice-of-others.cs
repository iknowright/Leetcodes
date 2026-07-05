public class Solution {
    public int DominantIndex(int[] nums) {
        int max=0, second=-1;
        for(int i=1; i<nums.Length; i++) {
            if(nums[i]>nums[max]) {
                second=max;
                max=i;
            }
            else if(second==-1 || nums[i]>nums[second]) second=i;
        }
        if(second==-1 || nums[max]>=nums[second]*2) return max;
        else return -1;
    }
}