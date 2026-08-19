public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int left=0, right=nums.Sum();
        int[] res = new int[nums.Length];
        for(int i=0; i<nums.Length; i++) {
            right-=nums[i];
            res[i] = Math.Abs(left-right);
            left+=nums[i];
        }
        return res;
    }
}