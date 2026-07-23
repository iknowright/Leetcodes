public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows==1 || s.Length<=numRows) return s;
        int cycle = 2*numRows-2;
        string res="";

        for(int i=0; i<numRows; i++) {
            for(int j=0; j+i<s.Length; j+=cycle) {
                res+=s[i+j];
                if(i!=0 && i!=numRows-1 && j+cycle-i<s.Length) {
                    res += s[j+cycle-i];
                }
            }
        }
        return res;
    }
}