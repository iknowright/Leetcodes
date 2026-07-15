public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> res=new();
        for(int i=0; i<s.Length; i++) {
            if(res.ContainsKey(s[i])) {
                if(res[s[i]]!=t[i]) return false;
            }
            else res[s[i]]=t[i];
        }
        return res.Values.Distinct().Count()==res.Count;
    }
}