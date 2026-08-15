public class Solution {
    public int MinimumSwaps(int[] nums) {
        int zero=0, res=0, i=0;
        foreach(int num in nums) if(num==0)zero++;
        while(i!=zero) if(nums[nums.Length-1-i++]!=0) res++;
        return res;
    }
}