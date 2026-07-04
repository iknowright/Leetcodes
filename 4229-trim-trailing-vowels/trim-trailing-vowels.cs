public class Solution {
    public string TrimTrailingVowels(string s) {
        int i=s.Length-1;
        string vowels="aieou";
        while(i>=0 && vowels.Contains(s[i])) i--;
        return s[..(i+1)];
    }
}