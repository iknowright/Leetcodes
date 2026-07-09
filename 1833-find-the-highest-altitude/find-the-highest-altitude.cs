public class Solution {
    public int LargestAltitude(int[] gain) {
        int peek=0, height=0;
        foreach(int i in gain) {
            height+=i;
            if(height>peek) peek=height;
        }
        return peek;
    }
}