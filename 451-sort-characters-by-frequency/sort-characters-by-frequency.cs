public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> counts=new();
        foreach(char c in s) counts[c]=counts.GetValueOrDefault(c)+1;
        var sorted = counts.Keys.ToList();
        sorted.Sort((a, b) => counts[b].CompareTo(counts[a]));

        StringBuilder res=new();
        foreach(char c in sorted) res.Append(c, counts[c]);
        return res.ToString();
    }
}