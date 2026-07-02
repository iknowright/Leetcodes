public class Solution {
    public int DigitFrequencyScore(int n) {
        Dictionary<int, int> history=new();
        int res=0, curr;
        while(n!=0) {
            curr=n%10;
            history[curr]=history.GetValueOrDefault(curr)+1;
            n/=10;
        }
        foreach(var (key, value) in history) {
            res+=key*value;
        }
        return res;
    }
}