public class Solution
{
    public int MySqrt(int x)
    {
        int start = 0;
        int end = x;

        if (x < 2)
            return x;

        while (end >= start)
        {
            int mid = start + (end - start) / 2;

            if (mid == x / mid)
                return mid;

            else if (mid < x / mid)
                start = mid + 1;

            else
                end = mid - 1;
        }

        return start - 1;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int x = 64;
        int result = solution.MySqrt(x);
        Console.WriteLine(result);
    }
}