public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int n in nums)
        {
            if (set.Contains(n)) return true;
            set.Add(n);
        }
        return false;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 2, 3, 1 };
        bool result = solution.ContainsDuplicate(nums);
        Console.WriteLine(result);
    }
}

