public class Solution {
    public bool JudgeSquareSum(int c) {
        long left=0, right=(long)Math.Sqrt(c), sum;
        while(left<=right) {
            sum = left*left + right*right;
            if(sum==c) return true;
            else if(sum<c) left++;
            else right--;
        }
        return false;
    }
}