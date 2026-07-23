public class Solution {
    public int LongestAlternatingSubarray(int[] nums, int threshold) {
        int curr=0, max=0;
        for(int i=0; i<nums.Length; i++) {
            if(nums[i]>threshold) curr=0;
            else if(curr>0 && nums[i]%2 != nums[i-1]%2) curr++;
            else if(nums[i]%2==0) curr=1;
            else curr=0;
            
            max = Math.Max(curr, max);
        }
        return max;
    }
}