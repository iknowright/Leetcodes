public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int> find=new();
        for(int i=0; i<arr.Length; i++) {
            if(find.Contains(arr[i])) return true;
            else if((arr[i]%2)==0) find.Add(arr[i]/2);
            find.Add(arr[i]*2);
        }
        return false;
    }
}