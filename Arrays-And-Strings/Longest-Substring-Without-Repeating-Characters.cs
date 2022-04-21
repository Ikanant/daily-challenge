public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 2) return s.Length;
        
        // a b c a b c b b
        // a a b
         
        var charMap = new int?[128];
        
        int li = 0; 
        int ld = 0;
        int cd = 0;
        for (int ri = 0; ri<s.Length; ri++){
            

            char c = s[ri];
            int? existingIndex = charMap[c];
            if (existingIndex.HasValue && existingIndex.Value >= li) {
                li = existingIndex.Value + 1;
            }
            
            cd = ri - li + 1;
            ld = cd > ld ? cd : ld;
            
            charMap[c] = ri;
        }
        
        return ld;
    }
}

// Given a string s, find the length of the longest substring without repeating characters.

// Example 1:

// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.

// Example 2:

// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.

// Example 3:

// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
