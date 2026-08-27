public class Solution {
    public int PossibleStringCount(string word) {
        int res=1;
        for(int i=1; i<word.Length; i++) {
            if(word[i]==word[i-1]) res++;
        }
        return res;
    }
}