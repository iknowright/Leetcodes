public class Solution {
    public string Interpret(string command) {
        string res="";
        for(int i=0; i<command.Length; i++) {
            if(command[i]=='G') res+='G';
            else {
                if(command[i+1]==')') {
                    i++;
                    res+='o';
                }
                else {
                    i+=3;
                    res+="al";
                }
            }
        }
        return res;
    }
}