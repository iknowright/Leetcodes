public class Solution {
    public string SortSentence(string s) {
        string[] words = s.Split(' ');
        string[] res = new string[words.Length];
        int index;
        foreach(string word in words) {
            index = word[word.Length-1]-'1';
            res[index] = word.Substring(0, word.Length-1);
        }
        return string.Join(" ", res);
    }
}