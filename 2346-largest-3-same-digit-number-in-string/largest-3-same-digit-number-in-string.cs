public class Solution {
    public string LargestGoodInteger(string num) {
        int max=0, curr=-1;
        for(int i=0; i<num.Length-2; i++) {
            if(num[i]==num[i+1] && num[i+1]==num[i+2]) {
                curr = int.Parse(num.Substring(i, 3));
                if(max<curr) max=curr;
            }
        }
        return curr!=-1? max.ToString("D3") : "";
    }
}