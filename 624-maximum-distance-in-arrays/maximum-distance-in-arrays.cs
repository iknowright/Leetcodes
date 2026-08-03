public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int res=0, min, max, currMin, currMax;
        min=arrays[0][0]; max=arrays[0][arrays[0].Count-1];

        for(int i=1; i<arrays.Count; i++) {
            currMin = arrays[i][0];
            currMax = arrays[i][arrays[i].Count-1];
            res=Math.Max(res, currMax-min);
            res=Math.Max(res, max-currMin);

            min=Math.Min(min, currMin);
            max=Math.Max(max, currMax);
        }
        return res;
    }
}