public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int max=0, last=-1;
        for(int i=0; i<seats.Length; i++) {
            if(seats[i]==1) {
                if(last==-1) max = Math.Max(max, i);
                else max = Math.Max(max, (i-last)/2);
                last=i;
            }
        }
        max = Math.Max(max, seats.Length-1-last);
        return max;
    }
}