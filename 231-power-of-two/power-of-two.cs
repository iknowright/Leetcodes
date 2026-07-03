public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n is 0) return false;
        while(n%2==0) n/=2;
        return n==1;
    }
}