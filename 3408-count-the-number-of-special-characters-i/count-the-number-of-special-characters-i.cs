public class Solution {
    public int NumberOfSpecialChars(string word) {
        int[] small =new int[26], big=new int[26];
        foreach(char c in word) {
            if(c is >='a' and <='z') small[c-'a']++;
            else if(c is >='A' and <='Z') big[c-'A']++;
        }

        int res=0;
        for(int i=0; i<26; i++) {
            if(small[i]!=0 && big[i]!=0) res++;
        }
        return res;
    }
}