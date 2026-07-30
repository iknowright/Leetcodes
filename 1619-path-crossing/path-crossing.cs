public class Solution {
    public bool IsPathCrossing(string path) {
        HashSet<string> res=new();
        int x=0, y=0;
        res.Add($"0,0");
        foreach(char c in path) {
            if(c is 'E') x++;
            else if(c is 'W') x--;
            else if(c is 'N') y++;
            else if(c is 'S') y--;

            if(!res.Add($"{x},{y}")) return true;
        }
        return false;
    }
}