public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int l=0, r=0, center=0;
        foreach(char move in moves) {
            if(move=='L') l++;
            else if(move=='R') r++;
            else center++;
        }
        return Math.Abs(l-r)+center;
    }
}