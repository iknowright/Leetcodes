public class Solution {
    public bool AreOccurrencesEqual(string s) {
        Dictionary<char, int> counts = new();
        foreach (char c in s) {
            counts[c] = counts.GetValueOrDefault(c)+1;
        }

        return counts.Values.Distinct().Count() == 1;
    }
}