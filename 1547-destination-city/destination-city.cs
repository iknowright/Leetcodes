public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> starts=new();
        foreach(var path in paths) {
            starts.Add(path[0]);
        }

        foreach(var path in paths) {
            if(!starts.Contains(path[1])) return path[1];
        }
        return "";
    }
}