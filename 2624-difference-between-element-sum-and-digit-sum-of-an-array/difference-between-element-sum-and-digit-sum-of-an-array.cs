public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int sum=0, digits=0, curr;
        foreach(int num in nums) {
            sum += num;
            curr = num;
            while(curr>0) {
                digits+= curr%10;
                curr/=10;
            }
        }
        return Math.Abs(sum-digits);
    }
}