public class Solution {
    public string RemoveDuplicates(string s) {
        char[] res= new char[s.Length];
        int prev=-1;

        for(int curr=0; curr<s.Length; curr++) {
            if(prev!=-1 && res[prev]==s[curr]) prev--;
            else { prev++; res[prev]= s[curr]; }
        }
        return new string(res, 0, prev+1);
    }
}