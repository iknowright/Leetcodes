public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int prev = -k-1;
        for(int i=0; i<nums.Length; i++) {
            if(nums[i]==1) {
                if(i-prev<=k) return false;
                prev = i; 
            }
        }
        return true;
    }
}