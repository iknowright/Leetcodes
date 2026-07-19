public class Solution {
    public bool AreNumbersAscending(string s) {
        string[] tokens = s.Split(' ');
        int prev = -1;
        foreach(string token in tokens) {
            if(int.TryParse(token, out int value)) {
                if(prev>=value) return false;
                prev = value;
            }
        }
        return true;
    }
}