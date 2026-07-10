public class Solution {
    int matches=0;
    public int NumberOfMatches(int n) {
        if(n<=2) matches+=n-1;
        else {
            matches+=n/2;
            NumberOfMatches((n+1)/2);
        }
        return matches;
    }
}