public class Solution {
    public string AddBinary(string a, string b) {
        int carry=0, i=a.Length-1, j=b.Length-1;
        int upper, lower, sum;
        string res="";
        while(i>=0 || j>=0 || carry==1) {
            upper = (i>=0 && a[i--]=='1')? 1:0;
            lower = (j>=0 && b[j--]=='1')? 1:0;
            sum = carry + upper + lower;
            carry= sum>=2? 1:0;
            res = (sum%2).ToString() + res;
        }
        return res;
    }
}