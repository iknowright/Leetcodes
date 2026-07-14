public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        HashSet<string> seen=new();
        int res=0;
        foreach(string word in words) {
            if(seen.Contains(word)) {
                seen.Remove(word);
                res++;
            }
            else seen.Add(new string(new char[]{word[1], word[0]}));
        }
        return res;
    }
}