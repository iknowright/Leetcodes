public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length) return false;

        int[] count= new int[26];
        foreach(char c in s1) count[c-'a']++;

        for(int i=0; i<s1.Length; i++) {
            count[s2[i]-'a']--;
        }

        for(int i=s1.Length; i<s2.Length; i++) {
            if(Array.TrueForAll(count, x => x==0)) return true;
            count[s2[i-s1.Length]-'a']++;
            count[s2[i]-'a']--;
        }

        return Array.TrueForAll(count, x => x==0);
    }
}