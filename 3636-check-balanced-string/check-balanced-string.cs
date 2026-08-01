public class Solution {
    public bool IsBalanced(string num) {
        int net=0; bool odd=false;
        for(int i=0; i<num.Length; i++) {
            if(odd) net-= num[i];
            else net+= num[i];
            odd=!odd;
        }
        return net==0 || net=='0';
    }
}