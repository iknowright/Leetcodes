public class Solution {
    public string SmallestPalindrome(string s) {
        int[] counts = new int[26];
        foreach(char c in s) {
            counts[c-'a']++;
        }
        StringBuilder left=new();
        string mid="";
        for(int i=0; i<26; i++) {
            if(counts[i]%2 !=0) mid = ((char)('a'+i)).ToString();

            if(counts[i] !=0) {
                left.Append((char)('a'+i), counts[i]/2);
            }
        }
        string leftStr= left.ToString(), rightStr=new string(leftStr.Reverse().ToArray());
        return leftStr+mid+rightStr;
    }
}