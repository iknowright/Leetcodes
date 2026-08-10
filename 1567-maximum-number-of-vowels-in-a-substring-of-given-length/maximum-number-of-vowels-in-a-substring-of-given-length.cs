public class Solution {
    public int MaxVowels(string s, int k) {
        int curr=0;
        for(int i=0; i<k; i++) {
            if(Vowel(s[i])) curr++;
        }
        
        int max=curr;
        for(int i=k; i<s.Length; i++) {
            if(Vowel(s[i])) curr++;
            if(Vowel(s[i-k])) curr--;
            max = Math.Max(max, curr);
        }
        return max;
    }
    public bool Vowel(char c) {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}