public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        int n=nums.Length;
        if(n<3) return n;
        else return 1 << (BitOperations.Log2((uint)n) + 1);
    }
}