public class Solution {
    public int LongestBalanced(string s) {
        int res=0, distinct, max, curr, length;

        for(int i=0; i<s.Length; i++) {
            int[] values = new int[26];
            distinct=0; max=0;
            for(int j=i; j<s.Length; j++) {
                curr=s[j]-'a';
                if(values[curr]++==0) distinct++;
                max = Math.Max(max, values[curr]);

                length = j-i+1;
                if(length == distinct*max) res = Math.Max(res, length);
            }
        }
        return res;
    }
}