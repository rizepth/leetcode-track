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

        //char[] specChar = { 'I', 'X', 'C' };
        int ret = 0;
        for(int i = 0; i < strLen - 1; i++){
            int current = dicts[s[i]];
            ret += (dicts[s[i+1]] > current ? -1 : 1) * current;
        }

        return ret + dicts[s[strLen-1]];
    }
}