public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers == null || numbers.Length == 0) {
            return null;
        }
        
        int x = 0;
        int y = numbers.Length - 1;
        
        while (y > x) {
            int result = numbers[x] + numbers[y];
            
            if (result == target) {
                return new int[] { x + 1, y + 1 }; 
            }
            
            if (result > target) {
                y--;
            } else {
                x++;
            }
        }
        
        return null;
    }
}