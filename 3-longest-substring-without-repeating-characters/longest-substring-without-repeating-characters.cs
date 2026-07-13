public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen=new();
        int max=0, temp, left=0;

        for(int i=0; i<s.Length; i++) {
            if(!seen.Add(s[i])) {
                while(seen.Contains(s[i])) {
                    seen.Remove(s[left++]);
                }
                seen.Add(s[i]);
            }
            max = Math.Max(max, i-left+1);
        }
        return max;
    }
}