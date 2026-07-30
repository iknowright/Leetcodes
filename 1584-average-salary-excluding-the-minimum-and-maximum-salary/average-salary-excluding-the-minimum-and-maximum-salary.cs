public class Solution {
    public double Average(int[] salary) {
        int max=salary[0], min=salary[0];
        foreach(int sal in salary) {
            max = Math.Max(max, sal);
            min = Math.Min(min, sal);
        }
        return (salary.Sum()-min-max)/(double)(salary.Length-2);
    }
}