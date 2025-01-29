public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        if(str.Length > 1){
            string reverseStr = String.Empty;
            for(int i = str.Length-1; i >= 0; i--){
                reverseStr += str[i];
            }
            if(str != reverseStr){
                return false;
            }
        }
        return true;
    }
}