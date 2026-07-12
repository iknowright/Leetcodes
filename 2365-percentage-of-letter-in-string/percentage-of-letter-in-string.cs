public class Solution {
    public int PercentageLetter(string s, char letter) {
        int res=0;
        foreach(char c in s) {
            if(c==letter) res++;
        }
        return res*100/s.Length;
    }
}