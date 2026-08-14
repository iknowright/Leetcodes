public class Solution {
    public bool IsSubstringPresent(string s) {
        HashSet<string> sets=new();
        for(int i=1; i<s.Length; i++) {
            sets.Add($"{s[i-1]}{s[i]}");
            if(sets.Contains($"{s[i]}{s[i-1]}")) return true;
        }
        return false;
    }
}