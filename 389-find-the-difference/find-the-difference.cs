public class Solution {
    public char FindTheDifference(string s, string t) {
        int res=0;
        foreach(char c in s) res^=(int)(c-'a');
        foreach(char c in t) res^=(int)(c-'a');
        return (char)('a'+res);
    }
}