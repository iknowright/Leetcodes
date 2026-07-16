public class Solution {
    public bool MakeEqual(string[] words) {
        int[] alphabets = new int[26];
        foreach(string word in words) {
            foreach(char c in word) alphabets[c-'a']++;
        }
        
        foreach(int alphabet in alphabets) {
            if(alphabet%words.Length !=0) return false;
        }
        return true;
    }
}