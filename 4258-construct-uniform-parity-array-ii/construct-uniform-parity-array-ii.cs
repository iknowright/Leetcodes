public class Solution {
    public bool UniformArray(int[] nums1) {
        int minOdd=int.MaxValue, minEven=int.MaxValue;

        foreach(int num in nums1) {
            if(num%2==0) minEven = Math.Min(minEven, num);
            else minOdd = Math.Min(minOdd, num);
        }

        return minOdd==int.MaxValue || minEven==int.MaxValue || minOdd<minEven;
    }
}