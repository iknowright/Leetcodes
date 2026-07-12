public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int num=0;
        foreach(string operation in operations) {
            if(operation[1]=='+') num++;
            else num--;
        }
        return num;
    }
}