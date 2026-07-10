public class Solution {
    public string ReplaceDigits(string s) {
        char[] str = s.ToCharArray();
        for(int i=1; i<s.Length; i++) {
            if(char.IsDigit(str[i])) str[i] = (char)(str[i-1] + str[i] - '0');
        }
        return new string(str);
    }
}