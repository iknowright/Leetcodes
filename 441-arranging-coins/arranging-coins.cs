public class Solution {
    public int ArrangeCoins(int n) {
        int count=0; int i=1;
        while(i<=n) {
            n-=i;
            i++;
            count++;
        }
        return count;
    }
}