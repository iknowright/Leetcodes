/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        return  Number(0, n);
    }

    public int Number(int left, int right) {
        int mid = left + (right-left)/2;
        int guessed = guess(mid);
        if(guessed==0) return mid;
        else if(guessed==-1) return Number(left, mid-1);
        else return Number(mid+1, right);
    }
}