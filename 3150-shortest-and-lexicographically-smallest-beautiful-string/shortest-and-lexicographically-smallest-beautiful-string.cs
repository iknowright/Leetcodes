public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int n=s.Length, one=0, left=0;
        string res="", curr;
        for(int right=0; right<n; right++) {
            if(s[right]=='1') one++;

            while(one==k) {
                curr = s.Substring(left, right-left+1);
                if(res is "" || curr.Length<res.Length || curr.Length==res.Length && string.Compare(curr, res)<0) res = curr; 
                if(s[left]=='1') one--;
                left++;
            }
        }
        return res;
    }
}