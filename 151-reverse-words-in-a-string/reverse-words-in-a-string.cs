public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}