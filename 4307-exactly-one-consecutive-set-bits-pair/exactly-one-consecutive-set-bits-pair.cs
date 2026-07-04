public class Solution {
    public bool ConsecutiveSetBits(int n) {
        bool found=false;
        while(n!=0) {
            if(n%2==1) {
                n/=2;
                if(n%2==1) {
                    if(found) return false;
                    else found=true;
                }
            }
            else n/=2;
        }
        return found;
    }
}