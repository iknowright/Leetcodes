public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, List<int>> dict=[];
        int row;
        foreach(var seat in reservedSeats) {
            row = seat[0];
            if(!dict.ContainsKey(row)) dict[row] = new List<int>();
            dict[row].Add(seat[1]);
        }
        long count = (long)(n - dict.Count)*2;
        List<int> res;
        foreach(var kvp in dict) {
            res = kvp.Value;
            bool left = !res.Contains(2) && !res.Contains(3) && !res.Contains(4) && !res.Contains(5);
            bool right = !res.Contains(6) && !res.Contains(7) && !res.Contains(8) && !res.Contains(9);
            bool middle = !res.Contains(4) && !res.Contains(5) && !res.Contains(6) && !res.Contains(7);

            if (left && right) count+=2;
            else if(left || right || middle) count+=1;
        }
        return (int)count;
    }
}