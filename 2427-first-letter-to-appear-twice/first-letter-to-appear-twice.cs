public class Solution {
    public char RepeatedCharacter(string s) {
        HashSet<char> res=new();
        foreach(char c in s) {
            if(!res.Add(c)) return c;
        }
        return s[0];
    }
}