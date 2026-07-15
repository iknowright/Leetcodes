public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] patterns = s.Split(' ');
        if(pattern.Length!=patterns.Length) return false;

        Dictionary<char, string> res=new();
        for(int i=0; i<pattern.Length; i++) {
            if(res.ContainsKey(pattern[i])) {
                if(res[pattern[i]]!=patterns[i]) return false;
            }
            else res[pattern[i]]=patterns[i];
        }
        return res.Count==res.Values.Distinct().Count();
    }
}