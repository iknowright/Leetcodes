public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> numbers = new HashSet<int>(nums);
        List<int> res=new();
        for(int i=1; i<=nums.Length; i++) {
            if(numbers.Add(i)) res.Add(i);
        }
        return res;
    }
}