public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> res=new();
        foreach(string word in words) {
            res.AddRange(word.Split(separator, StringSplitOptions.RemoveEmptyEntries));
        }
        return res;
    }
}