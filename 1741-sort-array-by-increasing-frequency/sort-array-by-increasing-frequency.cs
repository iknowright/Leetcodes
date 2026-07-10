public class Solution {
    public int[] FrequencySort(int[] nums) {
        Dictionary<int, int> count=new();

        foreach(int num in nums) {
            count[num]=count.GetValueOrDefault(num)+1;
        }
        return nums.OrderBy(num => count[num])
                .ThenByDescending(num => num).ToArray();
    }
}