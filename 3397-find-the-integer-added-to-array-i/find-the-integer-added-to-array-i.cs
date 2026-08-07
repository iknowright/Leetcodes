public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
        return (nums2.Sum()-nums1.Sum())/nums1.Length;
    }
}