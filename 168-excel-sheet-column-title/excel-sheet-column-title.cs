public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string title="";
        int curr;
        while(columnNumber-->0) {
            title= (char)('A' + columnNumber%26) + title;
            columnNumber/=26;
        }
        return title;
    }
}