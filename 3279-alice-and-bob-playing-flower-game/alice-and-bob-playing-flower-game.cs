public class Solution {
    public long FlowerGame(int n, int m) {
        return (long)(n+1)/2 * (m/2) + (long)(m+1)/2 * (n/2);
    }
}