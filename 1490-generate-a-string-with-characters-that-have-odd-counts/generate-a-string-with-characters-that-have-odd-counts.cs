public class Solution {
    public string GenerateTheString(int n) {
        if(n==1) return "a";
        return new string('a', n-2) + new string('b', 1) + (n%2==0?'a':'c');
    }
}