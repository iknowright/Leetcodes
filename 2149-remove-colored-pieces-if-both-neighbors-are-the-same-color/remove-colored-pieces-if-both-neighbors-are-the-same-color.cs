public class Solution {
    public bool WinnerOfGame(string colors) {
        int alice=0, bob=0;

        for(int i=1; i<colors.Length-1; i++) {
            if(colors[i]==colors[i-1] && colors[i]==colors[i+1]) {
                if(colors[i] is 'A') alice++;
                else bob++;
            }
        }
        return alice>bob;
    }
}