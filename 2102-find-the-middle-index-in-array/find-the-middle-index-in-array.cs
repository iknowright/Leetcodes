public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int left=0, right = nums.Sum();
        for(int i=0; i<nums.Length; i++) {
            right-=nums[i];
            if(left==right) return i;
            left+=nums[i];
        }
        return -1;
    }
}