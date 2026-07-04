public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max=0, curr=0;
        bool streak=false;
        foreach(int num in nums) {
            if(streak) {
                if(num==1) curr++;
                else {
                    streak=false;
                    if(curr>max) max=curr;
                    curr=0;
                }
            }
            else {
                if(num==1) {
                    streak=true;
                    curr=1;
                }
            }
        }
        return Math.Max(max, curr);
    }
}