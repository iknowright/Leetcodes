public class Solution {
    public int AlternateDigitSum(int n) {
        int res=0, curr;
        bool add=true;
        foreach(char c in n.ToString()) {
            curr=c-'0';
            res = res + (add? curr:-curr);
            add=!add;
        }
        return res;
    }
}