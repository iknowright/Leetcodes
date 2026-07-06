public class Solution {
    public string GenerateTheString(int n) {
        return new string('a', n-1) + (n%2==0?'b':'a');
    }
}