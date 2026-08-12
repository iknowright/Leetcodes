public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        Dictionary<int, int> counts = [];
        int left=0, max=0, curr;
        for(int right=0; right<nums.Length; right++) {
            curr=nums[right];
            counts[curr] = counts.GetValueOrDefault(curr)+1;
            while(counts[curr]==k+1) counts[nums[left++]]--;
            max = Math.Max(max, right-left+1);
        }
        return max;
    }
}