public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int max=arr[arr.Length-1], temp=max;
        arr[arr.Length-1]=-1;
        for(int i=arr.Length-2; i>=0; i--) {
            if(arr[i]>max) temp=arr[i];
            arr[i]=max;
            if(temp>max) max=temp;
        }
        return arr;
    }
}