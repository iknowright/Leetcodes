public class Solution {
    public string GreatestLetter(string s) {
        int[] arr = new int[26];
        foreach(char c in s) {
            if(char.IsLower(c)) arr[c-'a']|= 1;
            else arr[c-'A'] |= 2;
        }
        for(int i=25; i>=0; i--) {
            if(arr[i]==3) return ((char)('A'+i)).ToString();
        }
        return "";
    }
}