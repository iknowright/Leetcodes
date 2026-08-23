public class Solution {
    public bool SumGame(string num) {
        int left=0, right=0, diff=0, n=num.Length, curr;
        for(int i=0; i<n; i++) {
            if(num[i] is '?') {
                if(i<n/2) left++;
                else right++;
            }
            else {
                curr = num[i]-'0';
                diff+= (i<n/2)? curr:-curr;
            }
        }
        if(left==right) return diff!=0;
        // done from AI
        return 2*diff != 9 * (right-left);
    }
}