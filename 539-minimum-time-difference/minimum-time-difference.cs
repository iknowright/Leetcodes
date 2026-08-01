public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        int n = timePoints.Count;
        int[] minutes = new int[n];

        string time;
        for(int i=0; i<n; i++) {
            time = timePoints[i];
            minutes[i] = 60*int.Parse(time.Substring(0, 2)) + int.Parse(time.Substring(3, 2));
        }

        Array.Sort(minutes);
        int min = int.MaxValue;
        for(int i=1; i<minutes.Length; i++) {
            min = Math.Min(min, minutes[i]-minutes[i-1]);
        }
        return Math.Min(min, 1440 - (minutes[n-1]-minutes[0]));
    }
}