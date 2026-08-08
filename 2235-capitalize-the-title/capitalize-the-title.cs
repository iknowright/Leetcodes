public class Solution {
    public string CapitalizeTitle(string title) {
        string[] words = title.Split(' ');
        string curr;
        for(int i=0; i<words.Length; i++) {
            curr = words[i].ToLower();
            if(curr.Length>2) curr = char.ToUpper(curr[0]) + curr.Substring(1);
            words[i] = curr;
        }
        return string.Join(" ", words);
    }
}