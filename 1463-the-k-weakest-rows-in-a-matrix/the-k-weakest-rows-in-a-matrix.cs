public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        Dictionary<int, int> dict=new();

        for(int i=0; i<mat.Length; i++) {
            dict.Add(i, mat[i].TakeWhile(val => val==1).Count());
        }
        return dict.OrderBy(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Select(kvp => kvp.Key).Take(k).ToArray();
    }
}