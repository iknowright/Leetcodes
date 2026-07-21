public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        int ones=0;
        foreach(char c in s) {
            if(c is '1') ones++;
        }
        string[] zeroes = s.Split('1', StringSplitOptions.RemoveEmptyEntries);
        if(zeroes.Length<2) return ones;

        int maxZeroes=0, pairZeroes;
        for(int i=0; i<zeroes.Length-1; i++) {
            pairZeroes = zeroes[i].Length+zeroes[i+1].Length;
            maxZeroes = Math.Max(maxZeroes, pairZeroes);
        }
        return maxZeroes+ones;
    }
}