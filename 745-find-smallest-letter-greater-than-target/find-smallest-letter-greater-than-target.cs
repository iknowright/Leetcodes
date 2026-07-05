public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        char max = (char)('z'+1);
        foreach(char letter in letters) {
            if(letter>target && letter<max) max=letter;
        }
        return max==(char)('z'+1)? letters[0] : max;
    }
}