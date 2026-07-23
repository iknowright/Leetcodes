public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int median = nums[nums.Length/2];
        long res=0;
        foreach(int num in nums) {
            res += Math.Abs(num-median);
        }
        return (int)res;
    }
}