public class Solution {
    public int AbsDifference(int[] nums, int k) {
        Array.Sort(nums);
        int res=0;
        for(int i=0; i<k; i++) {
            res += nums[nums.Length-1-i]-nums[i];
        }
        return res;
    }
}