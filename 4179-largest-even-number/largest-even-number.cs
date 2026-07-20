public class Solution {
    public string LargestEven(string s) {
        int i=s.Length-1;
        while(i>=0 && s[i]=='1') i--;
        return s[..(i+1)];
    }
}