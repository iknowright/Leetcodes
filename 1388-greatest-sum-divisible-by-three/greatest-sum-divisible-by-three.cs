public class Solution {
    public int MaxSumDivThree(int[] nums) {
        int n11=int.MaxValue, n12=int.MaxValue, n21=int.MaxValue, n22=int.MaxValue, sum=0;
        foreach(int num in nums) {
            sum+=num;
            if(num%3==1) {
                if(num<n11) { n12=n11; n11=num; }
                else if(num<n12) n12=num;
            }
            else if(num%3==2) {
                if(num<n21) { n22=n21; n21=num; }
                else if(num<n22) n22=num;
            }
        }

        if(sum%3==1) {
            int option= (n21!=int.MaxValue && n22!=int.MaxValue)? n21+n22:int.MaxValue;
            return sum - Math.Min(option, n11);
        }
        else if(sum%3==2) {
            int option= (n11!=int.MaxValue && n12!=int.MaxValue) ? n11+n12:int.MaxValue;
            return sum - Math.Min(option, n21);
        }
        else return sum;
    }
}