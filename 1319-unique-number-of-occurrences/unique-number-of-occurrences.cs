public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dict=new();
        foreach(int num in arr) {
            dict[num]=dict.GetValueOrDefault(num)+1;
        }
        HashSet<int> res=new();
        foreach(int num in dict.Values) {
            if(!res.Add(num)) return false;
        }
        return true;
    }
}