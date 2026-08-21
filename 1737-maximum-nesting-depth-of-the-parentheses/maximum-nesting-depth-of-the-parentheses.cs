public class Solution {
    public int MaxDepth(string s) {
        int curr=0, max=0;
        foreach(char c in s) {
            if(c is '(') curr++;
            else if(c is ')') curr--;
            max = Math.Max(max, curr);
        }
        return max;
    }
}