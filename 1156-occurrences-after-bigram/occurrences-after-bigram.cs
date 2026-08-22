public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        string[] texts = text.Split(' ');
        List<string> res=new();
        for(int i=0; i<texts.Length-2; i++) {
            if(texts[i]==first && texts[i+1]==second) res.Add(texts[i+2]);
        }
        return res.ToArray();
    }
}