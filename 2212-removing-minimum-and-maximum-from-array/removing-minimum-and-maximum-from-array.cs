public class Solution {
    public int MinimumDeletions(int[] nums) {
        int min=0, max=0;
        for(int i=0; i<nums.Length; i++) {
            if (nums[i]<nums[min]) min=i;
            if (nums[i]>nums[max]) max=i;
        }

        if(min>max) {
            int temp=min; min=max; max=temp;
        }
        int left = max+1;
        int right = nums.Length - min;
        int both = min+1 + nums.Length-max;

        return Math.Min(both, Math.Min(left, right));
    }
}