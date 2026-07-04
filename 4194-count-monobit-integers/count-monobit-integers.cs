public class Solution {
    public int CountMonobit(int n) {
        int count=0;
        for(int i=0; i<=n; i++) {
            count+=Monobit(i);
        }
        return count;
    }
    public int Monobit(int num) {
        int bit=num%2;
        while(num!=0) {
            if(num%2 != bit) return 0;
            num/=2;
        }
        return 1;
    }
}