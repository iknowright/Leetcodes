public class Solution {
    public string FreqAlphabets(string s) {
        // start from right
        // number 1 to 9 'a' to 'i'
        // # number 10 to 26 'j' to 'z'
        char[] str = s.ToCharArray(); string res="";
        Array.Reverse(str);
        for(int i=0; i<str.Length; i++) {
            if(str[i]=='#') {
                int sum=str[i+1]-'0' + (str[i+2]-'0')*10-1;
                res+=(char)('a'+sum);
                i+=2;
            }
            else res+=(char)(str[i]-'1'+'a');
        }
        return new string(res.Reverse().ToArray());
    }
}