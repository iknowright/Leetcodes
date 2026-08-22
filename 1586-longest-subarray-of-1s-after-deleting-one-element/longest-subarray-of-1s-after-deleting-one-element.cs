public class Solution {
    public int LongestSubarray(int[] nums) {
        int left=0, zeros=0, max=0;

        for (int right=0; right<nums.Length; right++) {
            if (nums[right] == 0) zeros++;

            while (zeros>1) {
                if (nums[left] == 0) zeros--;
                left++;
            }

            max = Math.Max(max, right-left);
        }

        return max;
    }
}