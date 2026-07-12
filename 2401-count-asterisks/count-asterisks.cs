public class Solution {
    public int CountAsterisks(string s) {
        bool skip = false;
        int res=0;
        foreach(char c in s) {
            if(c is '|') skip=!skip;
            else if(!skip && c is '*') res++;
        }
        return res;
    }
}