public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {
        DateTime date = new(year, month, day);
        return date.ToString("dddd");
    }
}