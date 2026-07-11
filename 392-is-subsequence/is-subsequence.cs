public class Solution {
    public bool IsSubsequence(string s, string t) {
        int match=0;
        for(int i=0; i<t.Length; i++) {
            if(match<s.Length && t[i]==s[match])match++;
        }
        return match==s.Length;
    }
}