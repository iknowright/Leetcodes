public class Solution {
    public int[] SumZero(int n) {
        int[] res=new int[n];
        for(int i=0; i<n/2; i++) {
            res[i]=(i+1); res[i+n/2]=-1*(i+1);
        }
        if(n%2==1) res[n-1]=0;
        return res;
    }
}