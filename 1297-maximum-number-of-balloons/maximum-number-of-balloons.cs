public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] alphabets = new int[26];
        
        foreach(char c in text) {
            alphabets[c-'a']++;
        }

        int b=alphabets['b'-'a'], a=alphabets['a'-'a'];
        int l=alphabets['l'-'a']/2, o=alphabets['o'-'a']/2;

        return Math.Min(alphabets['n'-'a'], Math.Min(b, Math.Min(a, Math.Min(l, o))));    
    }
}