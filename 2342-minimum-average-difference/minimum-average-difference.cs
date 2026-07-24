public class Solution {
    public int MinimumAverageDifference(int[] nums) {
        int n=nums.Length, minIndex=0;
        long sum=0, prev=0, min=long.MaxValue, diff, left, right;
        foreach(int num in nums) sum+=num;

        for(int i=0; i<n; i++) {
            prev+=nums[i];
            left= prev/(i+1);
            right= (n-i-1==0)? 0: (sum-prev)/(n-i-1);
            diff = Math.Abs(left-right);

            if(diff<min) {
                min=diff; minIndex=i;
            }
        }
        return minIndex;
    }
}