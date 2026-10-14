
public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        HashSet<int> set = new HashSet<int>(nums);
        int maxLength = 0;
        foreach (int num in set) {
            if (!set.Contains(num - 1)) {
                int currentNum = num;
                int currentLength = 1;
                while (set.Contains(currentNum + 1)) {
                    currentNum++;
                    currentLength++;
                }
                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
}