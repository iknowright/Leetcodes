public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        bool left, right, top, bottom;
        left = rec1[2] <= rec2[0];
        right = rec1[0] >= rec2[2];
        top = rec1[3] <= rec2[1];
        bottom = rec1[1] >= rec2[3];
        return !(left || right || top || bottom);
    }
}