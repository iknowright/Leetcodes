public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        if(arr is null || arr.Length==0) return new int[0];

        int[] nums = (int[])arr.Clone();
        Array.Sort(nums);

        Dictionary<int, int> ranks=new();
        int rank=1;
        foreach(int num in nums) {
            if(!ranks.ContainsKey(num)) ranks[num]=rank++;
        }

        int[] res = new int[arr.Length];
        for(int i=0; i<arr.Length; i++) res[i]=ranks[arr[i]];
        
        return res;
    }
}