public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] res= new int[n*2];
        for(int i=0; i<n; i++) {
            res[2*i] = nums[i];
            res[2*i+1] = nums[n+i];
        }
        return res;
    }
}