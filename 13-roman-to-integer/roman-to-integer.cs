public class Solution {
    public int RomanToInt(string s) {
        int res=0, curr;
        for(int i=0; i<s.Length-1; i++) {
            curr=Roman(s[i]);
            res+= curr<Roman(s[i+1])?-1*curr:curr;
        }
        return res+Roman(s[s.Length-1]);
    }

    public int Roman(char c) => c switch {
        'I'=>1,
        'V'=>5,
        'X'=>10,
        'L'=>50,
        'C'=>100,
        'D'=>500,
        'M'=>1000
    };
}