public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int[] counts = new int[1001], res = new int[arr1.Length];
        foreach(int num in arr1) counts[num]++;

        int i=0;
        foreach(int num in arr2) {
            while(counts[num]>0) { 
                res[i++] = num; 
                counts[num]--; 
            }
        }
        for(int j=0; j<counts.Length; j++) {
            while(counts[j]>0) {
                res[i++] = j;
                counts[j]--;
            }
        }
        return res;
    }
}