/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        while(true) {
            int res = (Rand7()-1)*7 + Rand7();
            if(res<=40) return (res-1)%10 +1;
        }
    }
}