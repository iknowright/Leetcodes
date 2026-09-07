public class Solution {
    public int RearrangeCharacters(string s, string target) {
        var counts = s.GroupBy(c => c)
        .ToDictionary(g => g.Key, g => g.Count());
        return target.GroupBy(c => c)
        .Select(g => counts.TryGetValue(g.Key, out int count)? count/ g.Count() : 0).Min();
    }
}