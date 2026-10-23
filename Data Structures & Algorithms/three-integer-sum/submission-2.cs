public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            int x = i + 1;
            int y = nums.Length - 1;

            while (y > x) {
                int sum = nums[i] + nums[x] + nums[y];

                if (sum == 0) {
                    result.Add(new List<int> { nums[i], nums[x], nums[y] });
                    x++;
                    y--;

                    while (y > x && nums[x] == nums[x - 1]) x++;
                    while (y > x && nums[y] == nums[y + 1]) y--;
                } 
                else if (sum > 0) {
                    y--;
                } 
                else {
                    x++;
                }
            }
        }
        return result;
    }
}