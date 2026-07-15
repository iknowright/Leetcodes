public class Solution {
    public int ConvertTime(string current, string correct) {
        string[] s1=current.Split(':'), s2=correct.Split(':');

        int time =((24-int.Parse(s1[0])+int.Parse(s2[0]))%24)*60 
        + (int.Parse(s2[1])-int.Parse(s1[1]));
        int operations=0;
        while(time!=0) {
            if(time>=60) time-=60;
            else if(time>=15) time-=15;
            else if(time>=5) time-=5;
            else time-=1;
            operations++;
        }
        return operations;
    }
}