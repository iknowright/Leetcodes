public class Solution {
    public string ThousandSeparator(int n) {
        if(n==0) return "0";

        string res="";
        while(n!=0) {
            res = ((n>999)? ("."+(n%1000).ToString("D3")):(n%1000).ToString())+res;
            n/=1000;
        }
        return res;
    }
}