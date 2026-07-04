public class Solution {
    public int[] ScoreValidator(string[] events) {
        int[] res=new int[2];
        foreach(string score in events) {
            if(score is "WD" or "NB") res[0]+=1;
            else if(score is "W") {
                res[1]+=1;
                if(res[1]==10) return res;
            }
            else res[0]+=(int)(score[0]-'0');
        }
        return res;
    }
}