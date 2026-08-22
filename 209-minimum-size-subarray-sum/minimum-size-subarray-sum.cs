public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left=0, curr=0, min=int.MaxValue;
        for(int right=0; right<nums.Length; right++) {
            curr += nums[right];
            while(curr>=target) {
                min = Math.Min(min, right-left+1);
                curr-=nums[left++];
            }
        }
        return min==int.MaxValue? 0:min;
    }
}