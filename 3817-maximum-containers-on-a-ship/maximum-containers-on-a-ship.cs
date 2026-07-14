public class Solution {
    public int MaxContainers(int n, int w, int maxWeight) {
        return Math.Min(n*n, maxWeight/w);
    }
}