public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if(s.Length != goal.Length) return false;

        if(s==goal) {
            int[] counts= new int[26];
            foreach(char c in s) {
                counts[c-'a']++;
                if(counts[c-'a']>1) return true;
            }
            return false;
        }
        else {
            int diff=0; int[] diffs=new int[2];
            for(int i=0; i<s.Length; i++) {
                if(s[i] != goal[i]) {
                    if(diff==2) return false;
                    else diffs[diff++]=i;
                }
            }
            return diff==2 && s[diffs[0]]==goal[diffs[1]] && s[diffs[1]]==goal[diffs[0]];
        }
    }
}