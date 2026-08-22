public class Solution {
    public int[] ClosestDivisors(int num) {
        for(int i=(int)Math.Sqrt(num+2); i>0; i--) {
            if((num+1)%i==0) return [i, (num+1)/i];
            if((num+2)%i==0) return [i, (num+2)/i];
        }
        return [];
    }
}