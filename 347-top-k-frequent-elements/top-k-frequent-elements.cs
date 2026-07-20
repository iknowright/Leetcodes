public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> res=new();
        foreach(int num in nums) {
            res[num]=res.GetValueOrDefault(num)+1;
        }

        return res.OrderByDescending(kvp => kvp.Value)
        .Take(k).Select(kvp => kvp.Key).ToArray();
    }
}