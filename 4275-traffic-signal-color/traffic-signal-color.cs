public class Solution {
    public string TrafficSignal(int timer) => timer switch {
        0 => "Green",
        30 => "Orange",
        _ when timer>30 && timer<=90 => "Red",
        _ => "Invalid"
    };
}