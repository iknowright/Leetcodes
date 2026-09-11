public class Solution {
    public int TotalNumbers(int[] digits) {
        int[] thedigits= new int[10];
        foreach(int digit in digits) thedigits[digit]++;

        int res=0, unit, ten, hundred;
        for(int num=100; num<1000; num+=2) {
            hundred = num/100; 
            ten = (num/10) %10; 
            unit = num%10;

            int[] need=new int[10];
            need[hundred]++;
            need[ten]++;
            need[unit]++;

            bool done=true;
            for(int i=0; i<10; i++) {
                if(need[i]>thedigits[i]) {
                    done = false;
                    break;
                }
            }
            if(done) res++;
        }
        return res;
    }
}