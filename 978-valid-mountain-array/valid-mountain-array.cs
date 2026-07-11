public class Solution {
    public bool ValidMountainArray(int[] arr) {
        bool increasing=false, decreasing=false; 
        int i=0;
        while(i<arr.Length-1 && arr[i]<arr[i+1]) {
            i++;
            increasing=true;
        }
        while(i<arr.Length-1 && arr[i]>arr[i+1]) {
            i++;
            decreasing=true;
        }
        return i==arr.Length-1 && increasing && decreasing;
    }
}