public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int res=0;
        foreach(char stone in stones) {
            if(jewels.Contains(stone)) res++;
        }
        return res;
    }
}