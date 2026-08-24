public class Solution {
    public int MaxOperations(int[] nums) {
        int count = 1, sum = nums[0]+nums[1], i=2;
        while(i+1<nums.Length) {
            if(nums[i]+nums[i+1] == sum) count++;
            else break;
            i+=2;
        }
        return count;
    }
}