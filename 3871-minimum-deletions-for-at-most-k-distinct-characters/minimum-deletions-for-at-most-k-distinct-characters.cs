public class Solution {
    public int MinDeletion(string s, int k) {
        Dictionary<char, int> counts = new();
        foreach(char c in s) {
            counts[c] = counts.GetValueOrDefault(c)+1;
        }
        if(counts.Count <=k) return 0;
        
        List<int> freq = counts.Values.ToList();
        freq.Sort();

        int res=0;
        for(int i=0; i<counts.Count-k; i++) {
            res+=freq[i];
        }
        return res;
    }
}