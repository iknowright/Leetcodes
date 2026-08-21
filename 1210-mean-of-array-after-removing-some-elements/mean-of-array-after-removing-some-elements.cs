public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        double res=0.0;
        int len = arr.Length, remove = len/20;
        for(int i=len/20; i<len-remove; i++) {
            res+= arr[i];
        }
        return res/(len-2*remove);
    }
}