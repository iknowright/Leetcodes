public class Solution {
    public string RemoveOuterParentheses(string s) {
        int completed=0;
        StringBuilder res=new();
        foreach(char c in s) {
            if(c is '(') {
                if(completed++ >0) res.Append(c);
            }
            else {
                if((completed-- -1) >0) res.Append(c);
            }
        }
        return res.ToString();
    }
}