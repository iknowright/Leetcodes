public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, List<int>> dict=[];
        int row;
        foreach(var seat in reservedSeats) {
            row = seat[0];
            if(!dict.ContainsKey(row)) dict[row] = new List<int>();
            dict[row].Add(seat[1]);
        }
        long res = (long)(n - dict.Count)*2;
        List<int> reserved;
        foreach(var kvp in dict) {
            reserved = kvp.Value;
            bool left = !reserved.Contains(2) && !reserved.Contains(3) && !reserved.Contains(4) && !reserved.Contains(5);
            bool right = !reserved.Contains(6) && !reserved.Contains(7) && !reserved.Contains(8) && !reserved.Contains(9);
            bool middle = !reserved.Contains(4) && !reserved.Contains(5) && !reserved.Contains(6) && !reserved.Contains(7);

            if (left && right) res+=2;
            else if(left || right || middle) res+=1;
        }
        return (int)res;
    }
}