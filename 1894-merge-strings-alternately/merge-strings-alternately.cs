public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i=0, j=0;
        StringBuilder res=new();
        while(i<word1.Length || j<word2.Length) {
            if(i<word1.Length) res.Append(word1[i++]);
            if(j<word2.Length) res.Append(word2[j++]);
        }

        return res.ToString();
    }
}