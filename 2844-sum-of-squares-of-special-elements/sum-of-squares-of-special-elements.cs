public class Solution {
    public int SumOfSquares(int[] nums) {
        int square=0, n=nums.Length;
        for(int i=0; i<n; i++) {
            if(n%(i+1)==0) square += nums[i]*nums[i];
        }
        return square;
    }
}