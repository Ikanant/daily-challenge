public class Solution {
    public int MyAtoi(string s) {
        // "4193 with words"
        // "   -42"
        // "42"
        
        long res = 0;
        bool? isPos = null;
        bool partyStarted = false;
        long maxInt = (long)Math.Pow(2, 31) - 1;
        long minInt = (long)Math.Pow(2, 31) * -1;
        bool OVERFLEW = false;
        
        for (var i=0; i<s.Length; i++) {
            char c = s[i];
            
            if (c == ' ' && !partyStarted) continue;
            if (!isPos.HasValue && c == '+' && i<s.Length-1) {
                isPos = true;
                partyStarted = true;
                if (s[i+1] >= 48 && s[i+1] <= 57) continue;
                else break;
            }
            if (!isPos.HasValue && c == '-' && i<s.Length-1) {
                isPos = false;
                partyStarted = true;
                if (s[i+1] >= 48 && s[i+1] <= 57) continue;
                else break;
            }
                
            if (c < 48 || c > 57) break;
            
            if (res > (maxInt - ((int)c-48))/10) {
                OVERFLEW = true;
            }
            
            res = res*10 + ((int)c-48);
            isPos = isPos ?? true;
            partyStarted = true;
        }
        
        isPos = isPos ?? true;
        res = isPos.Value ? res : res*-1;
        
        
        if (OVERFLEW && isPos.Value) return (int) maxInt;
        else if (OVERFLEW && !isPos.Value) return (int) minInt;
        else return (int)res;
    }
}