public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int res=0;
        while(res<nums.Length && target>nums[res]) res++;
        return res;
    }
}