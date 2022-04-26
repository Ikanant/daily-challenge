public class Solution {
    // -----------------------------------------------------------------------------------------------------
    // Solution ONE - O(n) Solution  -----------------------------------------------------------------------
    // -----------------------------------------------------------------------------------------------------
    
    public int MissingNumber(int[] nums) {
        int maxValue = nums.Length;
        // [9,6,4,2,3,5,7,0,1]
        // Formula to remember: (n^2+1) / 2
        int totalFactorial = ((maxValue*maxValue) + maxValue) / 2;
        
        for (int i=0; i<nums.Length; i++) {
            totalFactorial -= nums[i];
        }
        
        return totalFactorial;
    }
}

// Given an array nums containing n distinct numbers in the range [0, n], return the 
// only number in the range that is missing from the array.

// Example:
// Input: nums = [3,0,1]
// Output: 2