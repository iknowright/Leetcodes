public class Solution {
    public int DuplicateNumbersXOR(int[] nums) {
        HashSet<int> res=new();
        int xor=0;

        foreach(int num in nums) {
            if(!res.Add(num)) xor^= num;
        }
        return xor;
    }
}