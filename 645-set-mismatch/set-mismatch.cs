public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] counts = new int[nums.Length+1];
        foreach(int num in nums) counts[num]++;

        int[] res= new int[2];
        for(int i=1; i<=nums.Length; i++) {
            if(counts[i]==2) res[0] = i;
            else if (counts[i]==0) res[1] = i;
        }
        return res;
    }
}