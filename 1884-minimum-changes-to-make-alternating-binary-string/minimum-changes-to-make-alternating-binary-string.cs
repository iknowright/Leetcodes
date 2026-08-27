public class Solution {
    public int MinOperations(string s) {
        int res=0;
        char wanted;
        for(int i=0; i<s.Length; i++) {
            wanted = (i%2==0)? '0':'1';
            if(s[i] != wanted) res++;
        }
        return Math.Min(res, s.Length-res);
    }
}