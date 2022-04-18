public class Solution {

// -----------------------------------------------------------------------------------------------------
// Using ONLY arrays -----------------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------------------
    public int[] TwoSum(int[] nums, int target) {
        // Input: nums = [3,2,4], target = 6
        // Output: [1,2]
        
        int[] a = new int[nums.Length];
        for (int i=0; i<nums.Length; i++) {
            int num = nums[i];
            int desiredNum = target-num;
            for (int j=0; j<i; j++) {
                if (a[j] == num) {
                    return new int[]{j, i};
                }
            }
            
            a[i] = desiredNum; // 3 4
        }
        return new int[]{};
    }
}

// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
