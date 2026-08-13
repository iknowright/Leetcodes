public class Solution {
    public bool IsNumber(string s) {
        bool digit=false, exponent=false, dot=false;
        char c;
        for(int i=0; i<s.Length; i++) {
            c = s[i];

            if(char.IsDigit(c)) digit = true;
            else if(c is '+' or '-') {
                if(i>0 && (s[i-1]!='e' && s[i-1]!='E')) return false;
            }
            else if(c is '.') {
                if(dot || exponent) return false;
                dot = true;
            }
            else if(c is 'e' or 'E') {
                if(!digit || exponent) return false;
                exponent = true; digit = false;
            }
            else return false;
        }

        return digit;
    }
}