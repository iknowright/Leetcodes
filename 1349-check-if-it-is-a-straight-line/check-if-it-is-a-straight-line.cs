public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        double dy=(coordinates[1][1]-coordinates[0][1]), dx=(coordinates[1][0]-coordinates[0][0]);
        for(int i=2; i<coordinates.Length; i++) {
            if(dy*(coordinates[i][0] - coordinates[0][0]) != dx*(coordinates[i][1] - coordinates[0][1])) return false;
        }
        return true;
    }
}