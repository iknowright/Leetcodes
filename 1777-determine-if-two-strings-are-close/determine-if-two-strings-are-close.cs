public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length != word2.Length) return false;
        int[] count1=new int[26], count2=new int[26];
        foreach(char c in word1) count1[c-'a']++;
        foreach(char c in word2) count2[c-'a']++;

        for(int i=0; i<26; i++) {
            if((count1[i]==0 && count2[i]>0) || (count2[i]==0 && count1[i]>0)) return false;
        }
        Array.Sort(count1); Array.Sort(count2);

        for(int i=0; i<26; i++) {
            if(count1[i] != count2[i]) return false;
        }

        return true;
    }
}