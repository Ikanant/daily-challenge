public class Solution {
    public string IntToRoman(int num) {
        // var a = 1994;
        // var b = "MCMXCIV";
        // 1 d 2 sum 3 sum 4 sub 5 d 6 sum 7 sum 8 sum 9 sub

        // int num = 1994;
        int power = 0;
        int singleDigit;
        string result = "";

        while (num > 0)
        {
            singleDigit = num % 10;

            result = ConvertToLetter(singleDigit, power) + result;

            num /= 10;
            power = power == 0 ? 10 : power*10;
        }

        return result;
    }
    
    public string ConvertToLetter(int i, int power) {
        string apple = "";

        var dic = new Dictionary<int, char>() {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' },
        };
        var dic2 = new Dictionary<char, char>() {
            { 'I', 'X' },
            { 'V', 'L' },
            { 'X', 'C' },
            { 'L', 'D' },
            { 'C', 'M' }
        };

        switch (i) {
            case 1:
                apple = "I";
                break;
            case 2:
                apple = "II";
                break;
            case 3:
                apple = "III";
                break;
            case 4:
                apple = "IV";
                break;
            case 5:
                apple = "V";
                break;
            case 6:
                apple = "VI";
                break;
            case 7:
                apple = "VII";
                break;
            case 8:
                apple = "VIII";
                break;
            case 9:
                apple = "IX";
                break;
        }

        string res;
        while (power > 1) {
            res = "";
            for (var j=0; j<apple.Length; j++) {
                res += dic2[apple[j]];
            }
            power /= 10;
            apple = res;
        }

        return apple;
    }
}