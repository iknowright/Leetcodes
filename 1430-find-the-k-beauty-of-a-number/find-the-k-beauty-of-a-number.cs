public class Solution {
    public int DivisorSubstrings(int num, int k) {
        string nums = num.ToString();
        int res=0, temp;
        for(int i=0; i<=nums.Length-k; i++) {
            temp = int.Parse(nums.Substring(i, k));
            if(temp!=0 && num%temp==0) res++;
        }
        return res;
    }
}