public class Solution {
    public string LongestPalindrome(string s) {
        int start=0, length=0;
        int odd=0, even=0, curr=0;
        for(int i=0; i<s.Length; i++) {
            odd = Palindrome(s, i, i);
            even = Palindrome(s, i, i+1);
            curr = Math.Max(odd, even);
            if(curr>length) {
                length = curr;
                start = i - (length-1)/2;
            }
        }
        return s.Substring(start, length);
    }
    public int Palindrome(string s, int left, int right) {
        while(left>=0 && right<s.Length && s[left]==s[right]) {
            left--; right++;
        }
        return right-left-1;
    }
}