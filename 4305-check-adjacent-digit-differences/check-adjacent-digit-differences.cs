public class Solution {
    public bool IsAdjacentDiffAtMostTwo(string s) {
        for(int i=0; i<s.Length-1; i++) {
            if(Math.Abs(s[i]-s[i+1])>2) return false;
        }
        return true;
    }
}