public class Solution {
    public void DuplicateZeros(int[] arr) {
        List<int> res=new();
        foreach(int num in arr) {
            res.Add(num);
            if(num==0) res.Add(0);
        }
        for(int i=0; i<arr.Length; i++) arr[i] = res[i];
    }
}