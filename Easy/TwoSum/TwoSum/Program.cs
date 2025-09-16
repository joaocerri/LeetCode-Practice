public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> sum = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complemento = target - nums[i];

            if (sum.ContainsKey(complemento))
            {
                return new int[] { sum[complemento], i };
            }

            sum[nums[i]] = i;
        }
        return null;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}