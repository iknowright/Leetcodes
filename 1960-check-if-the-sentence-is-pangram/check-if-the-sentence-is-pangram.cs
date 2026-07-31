public class Solution {
    public bool CheckIfPangram(string sentence) {
        int[] counts = new int[26];
        foreach(char c in sentence) counts[c-'a']++;

        foreach(int count in counts) {
            if(count is 0) return false;
        }
        return true;
    }
}