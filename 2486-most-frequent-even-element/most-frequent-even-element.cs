public class Solution {
    public int MostFrequentEven(int[] nums) {
        Dictionary<int, int> counts=new();
        foreach(int num in nums) {
            if(num%2==0) counts[num] = counts.GetValueOrDefault(num)+1;
        }
        if(counts.Count==0) return -1;
        return counts.OrderByDescending(kvp => kvp.Value)
        .ThenBy(kvp => kvp.Key).First().Key;
    }
}