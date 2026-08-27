public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> res=new();
        int separator, plus;
        string local, domain;

        foreach(string email in emails) {
            separator = email.IndexOf('@');
            local = email.Substring(0, separator);
            domain = email.Substring(separator);

            plus = local.IndexOf('+');
            if(plus!=-1) local = local.Substring(0, plus);

            local = local.Replace(".", "");

            res.Add(local+domain);
        }
        return res.Count;
    }
}