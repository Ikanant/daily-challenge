// WORK IN PROGRESS --->

public class Solution {
    public int Trap(int[] height) {
        if (height.Length<3) return 0;
        // int rightMostPilarIndex = height.Length-1;
        // int rightMostPilar = height[rightMostPilarIndex];
        // for (int a=height.Length-2; a>=0; a--) {
        //     if (rightMostPilar >= height[a]) {
        //         break;
        //     }
        //     rightMostPilar = height[a];
        //     rightMostPilarIndex = a;
        // }
        
        
        // 4 2 0 3 2 5
        //                X
        //  X             X
        //  X       X     X
        //  X  X    X  X  X
        //  X  X    X  X  X
        // -----------------
        // 2 4 1 2
        
        // 4 2 0 3 2 5
        //                
        //  X             
        //  X       X     
        //  X  X    X  X  
        //  X  X    X  X  X
        // -----------------
        //  0  1 2  3  4  5
        
        
        //  5,4,1,2
        //  X             
        //  X  X          
        //  X  X         
        //  X  X     X
        //  X  X  X  X
        // -------------
        //  0  1  2  3*
       
        // [9,6,8,8,5,6,3]
        
        
        
        // Find left-most pilar
        int leftMostPilarHeight = 0;
        int leftMostPilarIndex = 0;
        while (leftMostPilarIndex < height.Length) {
            if (height[leftMostPilarIndex] < leftMostPilarHeight) {
                leftMostPilarIndex--;
                break;
            }
            leftMostPilarHeight = height[leftMostPilarIndex];
            leftMostPilarIndex++;
        }
        
        // Find right-most pilar
        int rightMostPilarHeight = 0;
        int rightMostPilarIndex = height.Length-1;
        while (rightMostPilarIndex > leftMostPilarIndex) {
            if (height[rightMostPilarIndex] < rightMostPilarHeight) {
                rightMostPilarIndex++;
                break;
            }
            rightMostPilarHeight = height[rightMostPilarIndex];
            rightMostPilarIndex--;
        }
        
        int leftPilarHeight = height[leftMostPilarIndex];
        int leftPilarIndex = leftMostPilarIndex;
        int rightPilarHeight = 0;
        int rightPilarIndex = rightMostPilarIndex; 

        int trappedWaterAmount = 0;
        
        // [0,1,0,2,1,0,1,3,2,1,2,1]
        //                
        //               
        //                X
        //       X        X X   X
        // _ X _ X X _ X  X X X X X
        // --------------------------------
        
        // [*9,6,8,8,5,6*,3]
        
        for (int i=leftMostPilarIndex+1; i<=rightMostPilarIndex; i++) {
            if (height[i] >= height[leftPilarIndex] || i==rightMostPilarIndex) {
                rightPilarHeight = height[i];
                
                int diff = leftPilarHeight > rightPilarHeight ? rightPilarHeight : leftPilarHeight;
                
                for (int j=leftPilarIndex+1; j<i; j++) {
                    trappedWaterAmount += diff-height[j] > 0 ? diff-height[j] : 0;
                }
                
                leftPilarIndex = i;
                leftPilarHeight = height[leftPilarIndex];
            }
        }
        
        return trappedWaterAmount;
        
        
        
        
        
        
        
        
        
        
        
        
        
//         int leftPilar = 0;
//         int rightPilar = 0;
//         int amountOfWaterStored = 0;
//         for (int i=0; i<rightMostPilarIndex; i++) {
//             if (leftPilar <= height[i]) {
//                 leftPilar = height[i];
//                 rightPilar = 0;
//                 for (int j=i+1; j<=rightMostPilarIndex; j++) {
//                     if (height[j] > height[j-1] || j == rightMostPilarIndex) {
//                         rightPilar = height[j];
//                         break;
//                     }
//                 }
//                 continue;
//             }
            
//             int apple = leftPilar < rightPilar ? leftPilar : rightPilar;
//             amountOfWaterStored += apple - height[i] < 0 ? 0 : apple - height[i];
//             // 1 1 6 9
//         }
//         return amountOfWaterStored;
    }
}