public class Solution {
    public int LargestInteger(int[] nums, int k) {
        int n=nums.Length, max=-1;

        if(k==1) return nums.GroupBy(x => x)
        .Where(g => g.Count()==1).Select(g => g.Key).DefaultIfEmpty(max).Max();
        else if(k==n) return nums.Max();

        bool first = nums.Count(x => x==nums[0])==1, last = nums.Count(x => x==nums[n-1])==1;

        if(first) max = Math.Max(max, nums[0]);
        if(last) max = Math.Max(max, nums[n-1]);
        return max;
    }
}