public class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        int res=0;
        foreach(int num in nums) res += encrypt(num);
        return res;
    }

    public int encrypt(int num) {
        int count = 0, max = 0;
        while(num != 0) {
            max = Math.Max(max, num%10);
            count++;
            num /= 10;
        }
        return int.Parse(new string((char)('0'+max), count));
    }
}