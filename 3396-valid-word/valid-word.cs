public class Solution {
    public bool IsValid(string word) {
        if(word.Length<3) return false;
        bool vowel=false, consonant=false;
        foreach(char c in word) {
            if(!char.IsLetterOrDigit(c)) return false;
            else if(IsVowel(c)) vowel = true;
            else if(char.IsLetter(c)) consonant = true;
        }
        return vowel && consonant;
    }

    public bool IsVowel(char c) {
        return c is 'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U';
    }
}