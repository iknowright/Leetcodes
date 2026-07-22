public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m=nums1.Length, n=nums2.Length, total=m+n;
        int target=total/2;
        int i=0, j=0, prev=0, curr=0;
        for(int k=0; k<=target; k++) {
            prev=curr;
            if(i<m && (j>=n || nums1[i]<nums2[j])) curr=nums1[i++];
            else curr=nums2[j++];
        }
        if(total%2==1) return curr;
        else return (prev+curr)/2.0;
    }
}