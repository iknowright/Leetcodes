public class Solution {
    public int FirstMatchingIndex(string s) {
        int left=0, right=s.Length-1;
        while(left<=right) {
            if(s[left++]==s[right--]) return left-1;
        }
        return -1;
    }
}