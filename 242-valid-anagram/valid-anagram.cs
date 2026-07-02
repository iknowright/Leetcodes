public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] arr=new int [26];
        for(int i=0; i<s.Length; i++) {
            arr[s[i]-'a']+=1;
            arr[t[i]-'a']-=1;
        }
        return arr.All(x=> x==0);
    }
}