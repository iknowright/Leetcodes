public class Solution {
    public int HeightChecker(int[] heights) {
        int res=0;
        int[] expected = (int[]) heights.Clone();
        Array.Sort(expected);
        for(int i=0; i<heights.Length; i++) {
            if(heights[i]!=expected[i]) res++;
        }
        return res;
    }
}