public class Solution {
    public int VowelConsonantScore(string s) {
        int vowels=0, consonants=0;
        foreach(char c in s) {
            if(c is 'a' or 'e' or 'i' or 'o' or 'u') vowels++;
            else if(char.IsLetter(c)) consonants++;
        }
        if(consonants==0) return 0;
        else return vowels/consonants;
    }
}