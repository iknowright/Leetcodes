public class Solution {
    public bool IsSameAfterReversals(int num) {
        if(num is 0) return true;
        return num%10!=0;
    }
}