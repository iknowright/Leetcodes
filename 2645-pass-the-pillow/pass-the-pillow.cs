public class Solution {
    public int PassThePillow(int n, int time) {
        time = time % (2*n - 2);
        if(time<n) return time+1;
        else return 2*n - (time+1);
    }
}