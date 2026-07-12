public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        Dictionary<int, int> dict=new();
        foreach(int num in nums) {
            dict[num] = dict.GetValueOrDefault(num)+1;
        }

        int[] res=new int[2];
        foreach(int count in dict.Values) {
            res[0]+= count/2;
            res[1]+= count%2;
        }
        return res;
    }
}