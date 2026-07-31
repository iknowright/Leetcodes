public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        return Value(firstWord) + Value(secondWord) == Value(targetWord);
    }

    public int Value(string word) {
        int res=0;
        foreach(char c in word) {
            res = res*10 + (c-'a');
        }
        return res;
    }
}