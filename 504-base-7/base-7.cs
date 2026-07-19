public class Solution {
    public string ConvertToBase7(int num) {
        if(num==0) return "0";
        bool negative = num<0;
        long n = Math.Abs((long)num);

        string res="";
        while(n !=0) {
            res=(char)('0'+ (n%7))+res;
            n/=7;
        }

        if(negative) res = '-' + res;
        return res;
    }
}