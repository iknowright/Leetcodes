public class Solution {
    public int MinimumCardPickup(int[] cards) {
        Dictionary<int, int> values = [];
        int res = int.MaxValue;

        for(int i=0; i<cards.Length; i++) {
            if(values.ContainsKey(cards[i])) {
                res = Math.Min(res, i - values[cards[i]]+1);
            }
            values[cards[i]] = i;
        }

        return res == int.MaxValue? -1:res;
    }
}