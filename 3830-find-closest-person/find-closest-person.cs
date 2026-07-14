public class Solution {
    public int FindClosest(int x, int y, int z) {
        int res = Math.Abs(x-z)-Math.Abs(y-z);
        if(res is 0) return 0;
        else return res<0? 1:2;
    }
}