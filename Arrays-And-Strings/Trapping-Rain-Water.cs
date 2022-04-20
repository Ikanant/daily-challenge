// WORK IN PROGRESS --->

public class Solution {

    // -----------------------------------------------------------------------------------------------------
    // Solution THREE - O(n) Solution  ---------------------------------------------------------------------
    // -----------------------------------------------------------------------------------------------------
    public int Trap(int[] height) {
        // [0,1,0,2,1,0,1,3,2,1,2,1]
        // [5,4,1,2]
        // [0,2,0]
        // [4,2,0,3,2,4,3,4]
        // [8,2,8,9,0,1,7,7,9]

        // Going to loop twice:
        // One: Get tallest pilar:
        int tallestPilar = 0;
        int tallestPilarIndex = 0;
        for (int i = 0; i < height.Length; i++) {
            if (height[i] >= tallestPilar) {
                tallestPilar = height[i];
                tallestPilarIndex = i;
            }
        }

        int trappedWater = 0;

        // From the LEFT
        int leftMovingPilar = 0;
        for (int i = 0; i < tallestPilarIndex; i++) {
            if (height[i] > leftMovingPilar) {
                leftMovingPilar = height[i];
                continue;
            }
            int diff = leftMovingPilar - height[i];
            trappedWater += diff;
        }

        // From the RIGHT [0,1,0,2,1,0,1,3,2,1,2,1]
        int rightMovingPilar = 0;
        for (int j = height.Length - 1; j > tallestPilarIndex; j--) {
            if (height[j] > rightMovingPilar) {
                rightMovingPilar = height[j];
                continue;
            }

            int diff = rightMovingPilar - height[j];
            trappedWater += diff;
        }

        return trappedWater;
    }

    // -----------------------------------------------------------------------------------------------------
    // Solution TWO - Dirty Dictionary ---------------------------------------------------------------------
    // -----------------------------------------------------------------------------------------------------
    // public int Trap(int[] height) {
    //     Dictionary<int, List<int>> coordinates = new Dictionary<int, List<int>>();

    //     // [4,2,0,3,2,5]
    //     for (int i = 0; i < height.Length; i++) {
    //         int h = height[i];
    //         while (h > 0) {
    //             if (!coordinates.ContainsKey(h)) {
    //                 coordinates.Add(h, new List<int>() { i });
    //             } else {
    //                 coordinates[h].Add(i);
    //             }
    //             h--;
    //         }
    //     }

    //     int trappedWater = 0;
    //     foreach (var kv in coordinates) {
    //         if (kv.Value.Count > 1) {
    //             for (int j = 1; j < kv.Value.Count; j++) {
    //                 int diff = kv.Value[j] - kv.Value[j - 1] - 1;
    //                 trappedWater += diff;
    //             }
    //         }
    //     }
    //     return trappedWater;
    // }

    // -----------------------------------------------------------------------------------------------------
    // Solution ONE - Dirty Progressinve Solution ----------------------------------------------------------
    // -----------------------------------------------------------------------------------------------------

    // public int Trap(int[] height) {
    //     int lIndex = -1;
    //     int lHeight = 0;

    //     int rIndex = 0;
    //     int rHeight = 0;
    //     int trappedWater = 0;

    //     // [0,1,0,2,1,0,1,3,2,1,2,1]
    //     // [5,4,1,2]
    //     // [0,2,0]
    //     // [4,2,0,3,2,4,3,4]
    //     // [8,2,8,9,0,1,7,7,9]

    //     bool foundBase = false;
    //     for (int i = 0; i < height.Length - 1; i++) {
    //         if (height[i] > lHeight) {
    //             lIndex = i;
    //             lHeight = height[lIndex];
    //             continue;
    //         }

    //         for (int j = lIndex + 1; j < height.Length; j++) {
    //             if (j + 1 < height.Length && !foundBase && height[j] < height[j + 1]) {
    //                 foundBase = true;
    //                 continue;
    //             }
    //             if (foundBase) {
    //                 if (height[j] >= lHeight) {
    //                     rIndex = j;
    //                     rHeight = height[j];
    //                     break;
    //                 } else if (height[j] > rHeight) {
    //                     rIndex = j;
    //                     rHeight = height[rIndex];
    //                     // Continue
    //                 }
    //             }
    //         }

    //         if (foundBase) {
    //             int smallerPilar = lHeight > rHeight ? rHeight : lHeight;
    //             // Now we should have our pilars:
    //             for (int k = lIndex + 1; k < rIndex; k++) {
    //                 if (smallerPilar - height[k] > 0) {
    //                     trappedWater += smallerPilar - height[k];
    //                 }
    //             }

    //             i = lIndex = rIndex;
    //             lHeight = rHeight;
    //             rIndex = rHeight = 0;
    //             foundBase = false;
    //         }
    //     }

    //     return trappedWater;
    // }
}