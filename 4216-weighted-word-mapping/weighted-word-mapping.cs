public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        string maps="";
        foreach(string word in words) {
            maps+=Mapper(word, weights);
        }
        return maps;
    }
    public char Mapper(string word, int[] weights) {
        int count=0;
        foreach(char c in word) {
            count+=weights[c-'a'];
        }
        return (char)('z'-(count%26));
    }
}