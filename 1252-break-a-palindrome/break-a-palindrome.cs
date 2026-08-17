public class Solution {
    public string BreakPalindrome(string palindrome) {
        if(palindrome.Length==1) return "";

        char[] res = palindrome.ToCharArray();
        for(int i=0; i<res.Length/2; i++) {
            if(res[i]!='a') {
                res[i]='a'; return new string(res);
            }
        }
        res[res.Length-1]='b';
        return new string(res);
    }
}