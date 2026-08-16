public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int res=0, x, y;
        for(int i=1; i<points.Length; i++) {
            y = Math.Abs(points[i][1]-points[i-1][1]);
            x = Math.Abs(points[i][0]-points[i-1][0]);
            res += Math.Max(y, x);
        }
        return res;
    }
}