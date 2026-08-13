public class Solution {
    public static int FinalValueAfterOperations(string[] operations) {
        int num=0;
        foreach(string operation in operations) {
            if(operation[1] is '+') num++;
            else num--;
        }
        return num;
    }
}