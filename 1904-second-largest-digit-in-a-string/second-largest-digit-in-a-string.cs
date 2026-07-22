public class Solution {
    public int SecondHighest(string s) {
        HashSet<int> digits=new();
        foreach(char c in s) {
            if(char.IsDigit(c)) digits.Add(c-'0');
        }
        if(digits.Count<2) return -1;
        List<int> sort = digits.ToList();
        sort.Sort();
        return sort[sort.Count-2];
    }
}