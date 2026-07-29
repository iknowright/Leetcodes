public class Solution {
    public int SmallestNumber(int n, int t) {
        while(Product(n)%t !=0) n++;
        return n;
    }
    public int Product(int n) {
        int res=1;
        while(n!=0) {
            res*= n%10; n/=10;
        }
        return res;
    }
}