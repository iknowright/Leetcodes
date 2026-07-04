public class Solution {
    public int MinimumIndex(int[] capacity, int itemSize) {
        int res=-1;
        for(int i=0; i<capacity.Length; i++) {
            if(res is -1 && capacity[i]>=itemSize) res=i;
            else if(capacity[i]>=itemSize && capacity[i]<capacity[res]) res=i;
        }
        return res;
    }
}