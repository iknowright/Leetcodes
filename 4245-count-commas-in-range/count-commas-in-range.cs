public class Solution {
    public int CountCommas(int n) {
        if(n<Math.Pow(10,3)) return 0;
        return n-999;
    }
}