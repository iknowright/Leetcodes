public class Solution {
    public int CountSeniors(string[] details) {
        int old=0;
        foreach(string detail in details) {
            if(10*(detail[11]-'0') + detail[12]-'0' > 60) old++;
        }
        return old;
    }
}