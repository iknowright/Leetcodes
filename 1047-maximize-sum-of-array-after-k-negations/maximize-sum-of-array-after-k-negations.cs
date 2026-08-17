public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        for(int i=0; i<nums.Length && k>0; i++) {
            if(nums[i]<0) { nums[i] = -nums[i]; k--; }
        }

        if(k%2 !=0) {
            Array.Sort(nums); nums[0] = -nums[0];
        }

        return nums.Sum();
    }
}