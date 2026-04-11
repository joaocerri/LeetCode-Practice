public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int end = nums.Length - 1;
        int start = 0;
        int index = 0;

        while (start <= end)
        {
            int middle = start + (end - start) / 2;

            if (nums[middle] == target)
                return middle;

            if (nums[middle] < target)
                start = middle + 1;

            else
                end = middle - 1;
        }
        return start;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;
        int result = solution.SearchInsert(nums, target);
        Console.WriteLine(result); 
    }
}