public class Solution {
    public string LargestNumber(int[] nums) {
        string[] sNums= nums.Select(n => n.ToString()).ToArray();
        Array.Sort(sNums, (a, b) => (b+a).CompareTo(a+b));

        if(sNums[0] is "0") return "0";
        return string.Concat(sNums);
    }
}