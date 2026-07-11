public class Solution {
    public string AddStrings(string num1, string num2) {
        int a=num1.Length-1, b=num2.Length-1, carry=0, sum;
        string res="";
        while(a>=0 || b>=0 || carry==1) {
            sum=carry;
            sum += (a>=0? num1[a]-'0':0) + (b>=0? num2[b]-'0':0);
            carry=sum/10;
            res=(sum%10)+res;
            a--; b--;
        }
        return res;
    }
}