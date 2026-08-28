public class Solution {
    public int RemovePalindromeSub(string s) {
        int left=0, right=s.Length-1;
        while(left<right) {
            if(s[left++]!=s[right--]) return 2;
        }
        return 1;
    }
}