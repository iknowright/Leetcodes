public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);
        List<int> res=new();
        for(int i=0; i<nums.Length; i++) {
            if(nums[i]==target) res.Add(i);
        }
        return res;
    }
}