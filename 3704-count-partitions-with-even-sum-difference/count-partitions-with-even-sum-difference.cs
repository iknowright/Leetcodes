public class Solution {
    public int CountPartitions(int[] nums) {
        int res=0, rightSum=nums.Sum(), leftSum=0;
        for(int i=0; i<nums.Length-1; i++) {
            leftSum+=nums[i]; rightSum-=nums[i];
            if((leftSum-rightSum)%2==0) res++;
        }
        return res;
    }
}