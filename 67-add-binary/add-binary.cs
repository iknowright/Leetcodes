public class Solution {
    public string AddBinary(string a, string b) {
        int carry=0, i=a.Length-1, j=b.Length-1, sum;
        string res="";
        while(i>=0 || j>=0 || carry==1) {
            sum=carry;
            if(i>=0) sum+=a[i--]-'0';
            if(j>=0) sum+=b[j--]-'0';
            carry= sum>=2? 1:0;
            res = (sum%2).ToString() + res;
        }
        return res;
    }
}