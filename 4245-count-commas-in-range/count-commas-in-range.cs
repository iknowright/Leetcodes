public class Solution {
    public int CountCommas(int n) {
        if(n<1000) return 0;
        return n-999;
    }
}