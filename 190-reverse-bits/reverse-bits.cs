public class Solution {
    public int ReverseBits(int n) {
        int[] nums = new int[32];
        int res=0, len=31;
        while(n!=0) {
            nums[len--] = n%2;
            n/=2;
        }
        for(int i=0; i<nums.Length; i++) {
            res += nums[i] * (int)Math.Pow(2, i);
        }
        return res;
    }
}