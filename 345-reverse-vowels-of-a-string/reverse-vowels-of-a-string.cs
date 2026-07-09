public class Solution {
    public string ReverseVowels(string s) {
        List<int> list=new();
        char temp;
        char[] vowels = s.ToCharArray();

        for(int i=0; i<vowels.Length; i++) {
            if(vowels[i] is 'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U') list.Add(i);
        }
        int left=0, right=list.Count-1;
        while(left<=right) {
            temp=vowels[list[left]];
            vowels[list[left++]]=vowels[list[right]];
            vowels[list[right--]]=temp;
        }
        return new string(vowels);
    }

    public bool IsVowel(char c)
    {
        return (c is 'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U');
    }
}