public class Solution {
    public long CountCommas(long n) {
        long res=0, start=1000, end=999, comma=1, count;
        while(start<=n) {
            end = end*1000 +999;
            count = Math.Min(n, end) - start + 1;
            res += count*comma;
            start = end+1;
            comma++;
        }
        return res;
    }
}