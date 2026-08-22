public class Solution {
    public int MaxScore(string s) {
        int zeroes=0, ones = 0, max=0;
        foreach(char c in s) { if(c is '1') ones++; }

        for(int i=0; i<s.Length-1; i++) {
            if(s[i] is '0') zeroes++;
            else ones--;
            max = Math.Max(max, zeroes+ones);
        }
        return max;
    }
}