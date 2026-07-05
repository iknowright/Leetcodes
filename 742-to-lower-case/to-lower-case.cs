public class Solution {
    public string ToLowerCase(string s) {
        char[] str=s.ToCharArray();
        int change = 'A'-'a';
        for(int i=0; i<str.Length; i++) {
            if(str[i]>='A' && str[i]<='Z') str[i]=(char)(str[i]-change);
        }
        return new string(str);
    }
}