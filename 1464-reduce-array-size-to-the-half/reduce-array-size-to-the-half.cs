public class Solution {
    public int MinSetSize(int[] arr) {
        var freq = arr.GroupBy(x => x).Select(g => g.Count())
        .OrderByDescending(c => c).ToList();

        int count=0, res=0;
        foreach(int f in freq) {
            count += f;
            res++;
            if(count>=arr.Length/2) return res;
        }
        return res;
    }
}