public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int res=0, increment;

        for(int i=1; i<nums.Length; i++) {
            if(nums[i] <= nums[i-1]) {
                increment = nums[i-1]-nums[i]+1;
                nums[i]=nums[i-1]+1;
                res+=increment;
            }
        }
        return res;
    }
}