public class Solution {
    public int FindLucky(int[] arr) {
        int[] counts = new int[501];
        foreach(int num in arr) counts[num]++;

        for(int i=500; i>=1; i--) {
            if(counts[i]==i) return i;
        }
        return -1;
    }
}