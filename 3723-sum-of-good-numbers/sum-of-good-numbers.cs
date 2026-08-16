public class Solution {
    public int SumOfGoodNumbers(int[] nums, int k) {
        int res=0, n=nums.Length;
        for(int i=0; i<n; i++) {
            if(i+k<n && nums[i]<=nums[i+k]) continue;
            else if(i-k>=0 && nums[i]<=nums[i-k]) continue;
            else res+=nums[i];
        }
        return res;
    }
}