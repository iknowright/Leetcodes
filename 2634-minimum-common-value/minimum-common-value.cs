public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int l1 = nums1.Length, l2 = nums2.Length;
        int i=0, j=0;
        while(i<l1 && j<l2) {
            if(nums1[i]==nums2[j]) return nums1[i];
            else if(nums1[i]>nums2[j]) j++;
            else i++;
        }
        return -1;
    }
}