public class Solution {
    public string DecodeMessage(string key, string message) {
        char curr='a';
        Dictionary<char, char> res=new();
        foreach(char c in key) {
            if(c!=' ' && !res.ContainsKey(c)) {
                res[c]=curr++;
            }
            if(curr>'z') break;
        }

        string code="";
        foreach(char c in message) {
            if(c==' ') code+=c;
            else code+=res[c];
        }
        return code;
    }
}