public class Solution {
    public int TitleToNumber(string columnTitle) {
        int res=0;
        foreach(char c in columnTitle) {
            res = res*26 + (c-'A'+1);
        }
        return res;
    }
}