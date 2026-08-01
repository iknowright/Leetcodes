public class Solution {
    public int SuperPow(int a, int[] b) {
        int res=1;
        a%= 1337;
        foreach(int num in b) {
            res = (Pow(res, 10) * Pow(a, num)) % 1337;
        }

        return res;
    }

    public int Pow(int a, int b) {
        int res=1;
        a%= 1337;
        for(int i=1; i<=b; i++) res = (res*a)%1337;
        return res;
    }
}