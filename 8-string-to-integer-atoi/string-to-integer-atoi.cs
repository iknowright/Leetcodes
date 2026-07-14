public class Solution {
    public int MyAtoi(string s) {
        if(string.IsNullOrWhiteSpace(s)) return 0;
        int i=0, n=s.Length;

        while(i<n && s[i]==' ') i++;

        int sign=1;
        if(s[i]=='+' || s[i]=='-') {
            if(s[i]=='-') sign=-1;
            i++;
        }
        int res=0, digit;
        while(i<n && (s[i]>='0' && s[i]<='9')) {
            digit = (s[i++]-'0');
            if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && digit > int.MaxValue % 10)) {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }
            res = res*10 + digit;
        }
        return res*sign;
    }
}