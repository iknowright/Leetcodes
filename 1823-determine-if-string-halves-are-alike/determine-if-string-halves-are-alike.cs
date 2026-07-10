public class Solution {
    public bool HalvesAreAlike(string s) {
        int half = s.Length / 2;
        return Vowels(s[..half])==Vowels(s[half..]);
    }
    public int Vowels(string s) {
        int count=0;
        foreach(char c in s) {
            if(c is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U') count++;
        }
        return count;
    }
}