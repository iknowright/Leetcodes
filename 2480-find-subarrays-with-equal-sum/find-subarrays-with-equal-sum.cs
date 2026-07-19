public class Solution {
    public bool FindSubarrays(int[] nums) {
        HashSet<int> sum=new();
        for(int i=0; i<nums.Length-1; i++) {
            if(!sum.Add(nums[i]+nums[i+1])) return true;
        }
        return false;
    }
}