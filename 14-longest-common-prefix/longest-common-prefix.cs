public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        for(int i=0; i<strs[0].Length; i++) {
            if(!strs.All(s => s[i]==strs[0][i])) return strs[0][..i];
        }
        return strs[0];
    }
}