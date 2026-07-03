public class Solution {
    public int LengthOfLastWord(string s) {
        int res=0, i=s.Length-1;
        while(i>=0 && s[i]==' ') i--;
        while(i>=0 && s[i] != ' ') {
            i--; res++;
        }
        return res;
    }
}