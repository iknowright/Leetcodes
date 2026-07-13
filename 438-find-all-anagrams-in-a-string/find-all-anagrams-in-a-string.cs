public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> res=new();
        if(s.Length<p.Length) return res;
        int[] pArr=new int[26], sArr=new int[26];
        foreach(char c in p) pArr[c-'a']++;
        
        for(int i=0; i<p.Length; i++) sArr[s[i]-'a']++;

        for(int i=p.Length-1; i<s.Length; i++) {
            if (Enumerable.SequenceEqual(pArr, sArr)) {
                res.Add(i - p.Length + 1);
            }
            if(i+1<s.Length) {
                sArr[s[i-p.Length+1]-'a']--;
                sArr[s[i+1]-'a']++;
            }
        }

        return res;
    }
}