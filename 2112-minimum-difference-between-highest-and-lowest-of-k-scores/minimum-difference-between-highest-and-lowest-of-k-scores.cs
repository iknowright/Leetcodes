public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        if(k is 1) return 0;

        Array.Sort(nums);
        int min=int.MaxValue, curr;
        for(int i=0; i<=nums.Length-k; i++) {
            curr= nums[i+k-1]-nums[i];
            if(curr<min) min=curr;
        }
        return min;
    }
}