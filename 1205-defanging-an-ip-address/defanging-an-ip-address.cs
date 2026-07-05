public class Solution {
    public string DefangIPaddr(string address) {
        string defanged="";
        foreach(char c in address) {
            if(c is '.') defanged+="[.]";
            else defanged+=c;
        }
        return defanged;
    }
}