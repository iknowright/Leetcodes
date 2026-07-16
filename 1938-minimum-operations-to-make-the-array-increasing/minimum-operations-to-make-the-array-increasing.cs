public class Solution {
    public int MinOperations(int[] nums) {
        int max = nums[0], count=0;
        for(int i=1; i<nums.Length; i++) {
            if(nums[i]>max) {
                max=nums[i];
            }
            else {
                max++;
                count+=max-nums[i];
                nums[i]=max;
            }
        }
        return count;
    }
}