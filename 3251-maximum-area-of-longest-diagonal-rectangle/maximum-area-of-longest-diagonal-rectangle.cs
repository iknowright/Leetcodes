public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int area=0; double diagonal, max=0.0;
        foreach(var dimension in dimensions) {
            diagonal = Math.Sqrt(dimension[0]*dimension[0]+dimension[1]*dimension[1]);
            if(max<diagonal) {
                max=diagonal;
                area=dimension[0]*dimension[1];
            }
            else if(max==diagonal) {
                area = Math.Max(area, dimension[0]*dimension[1]);
            }
        }

        return area;
    }
}