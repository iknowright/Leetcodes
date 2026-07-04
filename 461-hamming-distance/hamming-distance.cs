public class Solution {
    public int HammingDistance(int x, int y) {
        int num= x^y, ones=0;
        while(num!=0) {
            if(num%2==1) ones++;
            num/=2;
        }
        return ones;
    }
}