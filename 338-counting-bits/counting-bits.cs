public class Solution {
    List<int> res=new();
    public int[] CountBits(int n) {
        for(int i=0; i<=n; i++) {
            res.Add(Remainder(i));
        }
        return res.ToArray();
    }
    public int Remainder(int n) {
        int ones=0;
        while(n is not 0) {
            if(n%2==1) ones++;
            n/=2;
        }
        return ones;
    }
}