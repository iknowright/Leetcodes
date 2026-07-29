public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int[] counts = new int[26];
        int res=0;
        for(int i=0; i<s.Length; i++) {
            counts[s[i]-'a']=i;
        }
        for(int i=0; i<t.Length; i++) {
            res+= Math.Abs(counts[t[i]-'a']-i);
        }
        return res;
    }
}