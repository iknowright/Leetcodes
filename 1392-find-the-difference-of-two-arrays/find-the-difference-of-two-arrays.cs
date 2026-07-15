public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var hash1=new HashSet<int>(nums1); 
        var hash2=new HashSet<int>(nums2);
        
        List<int> res1=new(), res2=new();
        foreach(int num in hash1) {
            if(!hash2.Contains(num)) res1.Add(num);
        }
        foreach(int num in hash2) {
            if(!hash1.Contains(num)) res2.Add(num);
        }
        return new List<IList<int>> {res1, res2};
    }
}