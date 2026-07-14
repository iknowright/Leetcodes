public class Solution {
    public int MaxFreqSum(string s) {
        int[] arr = new int[26];
        for(int i=0; i<s.Length; i++) {
            arr[s[i]-'a']++;
        }
        int vowel=0, consonant=0;
        for(int i=0; i<26; i++) {
            if(i is 0 or 4 or 8 or 14 or 20) {
                vowel = Math.Max(vowel, arr[i]);
            }
            else consonant = Math.Max(consonant, arr[i]);
        }
        return vowel + consonant;
    }
}