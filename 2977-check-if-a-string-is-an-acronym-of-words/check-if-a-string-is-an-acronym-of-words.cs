public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        string acronym="";
        foreach(string word in words) acronym+=word[0];
        return acronym == s;
    }
}