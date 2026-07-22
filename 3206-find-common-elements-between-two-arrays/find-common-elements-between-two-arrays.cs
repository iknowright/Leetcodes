public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        HashSet<int> set1=new(nums1), set2=new(nums2);
        int count1=0, count2=0;

        foreach(int num in nums1) {
            if(set2.Contains(num)) count1++;
        }

        foreach(int num in nums2) {
            if(set1.Contains(num)) count2++;
        }

        return new int[] {count1, count2};
    }
}