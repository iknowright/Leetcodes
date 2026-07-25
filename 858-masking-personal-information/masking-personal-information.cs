public class Solution {
    public string MaskPII(string s) {
        if(s.Contains('@')) {
            s= s.ToLower();
            int i=s.IndexOf('@');
            string mail = s.Substring(0, i), domain=s.Substring(i);

            return $"{mail[0]}*****{mail[mail.Length-1]}{domain}";
        }
        else {
            string digits= new string(s.Where(char.IsDigit).ToArray());
            string number = "***-***-" + digits.Substring(digits.Length-4);
            if(digits.Length==10) return number;
            else return "+" + new string('*', digits.Length-10) + "-" + number;
        }
    }
}