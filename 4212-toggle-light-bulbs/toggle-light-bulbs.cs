public class Solution {
    public IList<int> ToggleLightBulbs(IList<int> bulbs) {
        HashSet<int> onBulbs=new();
        foreach(int bulb in bulbs) {
            if(!onBulbs.Add(bulb)) onBulbs.Remove(bulb);
        }

        List<int> res= onBulbs.ToList();
        res.Sort();
        return res;
    }
}