public class Solution {
    public int RomanToInt(string s) {
        int strLen = s.Length;
        Dictionary<char,int> dicts = new Dictionary<char,int>();
        dicts.Add('I',1);
        dicts.Add('V',5);
        dicts.Add('X',10);
        dicts.Add('L',50);
        dicts.Add('C',100);
        dicts.Add('D',500);
        dicts.Add('M',1000);

        char[] specChar = { 'I', 'X', 'C' };
        int ret = 0;
        for(int i = 0; i < strLen; i++){
            int numToAdd = dicts[s[i]];
            if(i != (strLen - 1) && specChar.Contains(s[i])){
                if(dicts[s[i+1]] > dicts[s[i]]){
                    numToAdd = dicts[s[i+1]] - dicts[s[i]];
                    i++;
                }
            }
            ret = ret + numToAdd;
        }

        return ret;
    }
}