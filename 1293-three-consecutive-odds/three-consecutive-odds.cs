public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        bool first=false, second=false;
        foreach(int num in arr) {
            if(num%2==1) {
                if(!first) first=true;
                else if(first && !second) second=true;
                else if(first && second) return true;
            }
            else {
                first = false; second = false;
            }
        }
        return false;
    }
}