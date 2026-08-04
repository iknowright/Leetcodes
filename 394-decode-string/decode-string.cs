public class Solution {
    public string DecodeString(string s) {
        Stack<int> counts=new();
        Stack<string> strings=new();
        string res="";
        int curr=0;

        foreach(char c in s) {
            if(char.IsDigit(c)) curr= curr*10 + (c-'0');
            else if(c is '[') {
                counts.Push(curr); curr=0;
                strings.Push(res); res="";
            }
            else if(c is ']') {
                res = strings.Pop() + string.Concat(Enumerable.Repeat(res, counts.Pop()));
            }
            else res+=c;
        }
        return res;
    }
}