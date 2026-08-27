public class Solution {
    public string GetEncryptedString(string s, int k) {
        return s.Substring(k%s.Length) + s.Substring(0, k%s.Length);
    }
}