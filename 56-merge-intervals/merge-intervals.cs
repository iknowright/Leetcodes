public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length==1) return intervals;

        List<int[]> res=new();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        res.Add(intervals[0]);

        for(int i=1; i<intervals.Length; i++) {
            int[] prev= res[res.Count-1];
            if(prev[1]>=intervals[i][0]) prev[1]=Math.Max(prev[1], intervals[i][1]);
            else res.Add(intervals[i]);
        }
        return res.ToArray();
    }
}