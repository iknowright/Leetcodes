public class Solution {
    public bool CheckString(string s) {
        int i=0;
        while(i<s.Length && s[i]!='b') i++;
        for(; i<s.Length; i++) {
            if(s[i] is 'a') return false;
        }
        return true;
    }
}