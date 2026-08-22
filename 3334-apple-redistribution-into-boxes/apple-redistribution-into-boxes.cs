public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int apples = apple.Sum(), count=0;
        Array.Sort(capacity);
        for(int i=capacity.Length-1; i>=0; i--) {
            if(apples<=0) break;
            apples-= capacity[i];
            count++;
        }
        return count;
    }
}