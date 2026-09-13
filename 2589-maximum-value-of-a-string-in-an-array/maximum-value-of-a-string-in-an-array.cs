public class Solution {
    public int MaximumValue(string[] strs) {
        int max=0;
        foreach(string s in strs) {
            if(int.TryParse(s, out int val)) {
                max = Math.Max(max, val);
            } else max = Math.Max(max, s.Length);
        }
        return max;
    }
}