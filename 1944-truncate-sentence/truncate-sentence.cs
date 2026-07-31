public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] split = s.Split(' ');
        return string.Join(" ", split[..k]);
    }
}