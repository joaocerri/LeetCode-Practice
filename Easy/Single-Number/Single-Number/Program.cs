public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> singleNumber = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (singleNumber.ContainsKey(i))
                singleNumber[i]++;
            else
                singleNumber.Add(i, 1);
        }
        foreach (KeyValuePair<int, int> pair in singleNumber)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 4, 1, 2, 1, 2 };
        int result = solution.SingleNumber(nums);
        Console.WriteLine(result);
    }
}