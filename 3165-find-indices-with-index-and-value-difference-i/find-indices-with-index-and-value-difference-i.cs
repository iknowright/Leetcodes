public class Solution {
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference) {
        int min=0, max=0, left=0;
        for(int right=indexDifference; right<nums.Length; right++) {
            if(nums[left]<nums[min]) min = left;
            if(nums[left]>nums[max]) max = left;
            left++;

            if(nums[max]-nums[right]>=valueDifference) return [max, right];
            if(nums[right]-nums[min]>=valueDifference) return [right, min];
        }
        return [-1, -1];
    }
}