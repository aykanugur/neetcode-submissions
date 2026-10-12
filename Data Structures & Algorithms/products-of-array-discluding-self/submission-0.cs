public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int product = 1;
        int zeroCount = 0;

        int[] result = new int[nums.Length];

        foreach (int num in nums)
        {
            if (num == 0)
            {
                zeroCount++;
            }
            else
            {
                product *= num;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (zeroCount > 1)
            {
                result[i] = 0;
            }
            else if (zeroCount == 1)
            {
                if (nums[i] == 0)
                {
                    result[i] = product;
                }
                else
                {
                    result[i] = 0;
                }
            }
            else
            {
                result[i] = product / nums[i];
            }
        }

        return result;
    }
}