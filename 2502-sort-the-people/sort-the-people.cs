public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int, string> dict=new();
        for(int i=0; i<names.Length; i++) {
            dict[heights[i]] = names[i];
        }

        return dict.Keys.OrderByDescending(h => h)
        .Select(h => dict[h]).ToArray();
    }
}