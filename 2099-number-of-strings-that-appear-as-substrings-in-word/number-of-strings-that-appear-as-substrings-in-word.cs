public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int num=0;
        foreach(string pattern in patterns) {
            if(word.Contains(pattern)) num++;
        }
        return num;
    }
}