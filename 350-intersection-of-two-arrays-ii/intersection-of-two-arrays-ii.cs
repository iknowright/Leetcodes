public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1.Length>nums2.Length) return Intersect(nums2, nums1);

        Dictionary<int, int> res=new();
        foreach(int num in nums1) {
            res[num]=res.GetValueOrDefault(num)+1;
        }
        List<int> arr=new();
        foreach(int num in nums2) {
            if(res.TryGetValue(num, out int count) && count>0) {
                arr.Add(num);
                res[num] = count-1;
            }
        }
        return arr.ToArray();
    }
}