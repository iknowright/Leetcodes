public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int res=0;
        foreach(int hour in hours) {
            if(hour>=target) res++;
        }
        return res;
    }
}