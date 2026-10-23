public class Solution {
    public int MaxArea(int[] heights) {
        int x = 0;
        int y = heights.Length - 1;
        int max = 0;

        while (y > x) {
            int min = Math.Min(heights[x], heights[y]);
            int current = min * (y - x);

            if (current > max) {
                max = current;
            }

            if (min == heights[x]) {
                x++;
            } else {
                y--;
            }
        }
        return max;
    }
}