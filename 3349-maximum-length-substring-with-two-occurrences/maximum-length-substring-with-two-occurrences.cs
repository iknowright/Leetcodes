public class Solution {
    public int MaximumLengthSubstring(string s) {
        int[] counts = new int[26];
        int left=0, max=0;

        for(int right=0; right<s.Length; right++) {
            counts[s[right]-'a']++;

            while(counts[s[right]-'a']>2) counts[s[left++]-'a']--;

            max = Math.Max(max, right-left+1);
        }
        return max;
    }
}