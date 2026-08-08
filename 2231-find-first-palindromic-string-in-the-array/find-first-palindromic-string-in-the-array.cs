public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string word in words) {
            if(Palindrome(word)) return word;
        }
        return "";
    }
    public bool Palindrome(string word) {
        int left=0, right=word.Length-1;
        while(left<right) {
            if(word[left++]!=word[right--]) return false;
        }
        return true;
    }
}