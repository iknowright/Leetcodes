public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        int res=0;
        for(int i=0; i<nums.Length; i++) {
            res=res^(i+1)^nums[i];
        }
        return res;
    }
}