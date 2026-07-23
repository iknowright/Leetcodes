public class Solution {
    public string ComplexNumberMultiply(string num1, string num2) {
        var a = Array.ConvertAll(num1.TrimEnd('i').Split('+'), int.Parse);
        var b = Array.ConvertAll(num2.TrimEnd('i').Split('+'), int.Parse);
        return $"{ a[0]*b[0] - a[1]*b[1] }+{ a[0]*b[1] + a[1]*b[0] }i";
    }
}