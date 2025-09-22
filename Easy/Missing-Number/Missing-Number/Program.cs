public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        // soma esperada de 0 até n
        long expected = (long)n * (n + 1) / 2;

        long actual = 0;
        foreach (int x in nums)
        {
            actual += x;
        }

        return (int)(expected - actual);
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 3, 0, 1 };
        int missingNumber = solution.MissingNumber(nums);
        Console.WriteLine($"Missing number: {missingNumber}"); 
}
