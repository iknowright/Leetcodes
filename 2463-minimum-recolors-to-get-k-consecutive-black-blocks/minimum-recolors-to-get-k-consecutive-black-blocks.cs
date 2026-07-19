public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int w=0, min=0;
        for(int i=0; i<k; i++) {
            if(blocks[i]=='W') w++;
        }

        min=w;
        for(int i=k; i<blocks.Length; i++) {
            if(blocks[i-k]=='W') w--;
            if(blocks[i]=='W') w++;
            if(w<min) min=w;
        }
        return min;
    }
}