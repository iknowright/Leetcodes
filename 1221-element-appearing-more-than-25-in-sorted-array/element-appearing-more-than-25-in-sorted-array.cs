public class Solution {
    public int FindSpecialInteger(int[] arr) {
        double max = arr.Length/4.0;
        Dictionary<int, int> history = new();
        foreach(int num in arr) {
            history[num] = history.GetValueOrDefault(num)+1;
            if(history[num]>max) return num;
        }
        return arr[0];
    }
}