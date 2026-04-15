public class Solution
{
    public double MyPow(double x, int n)
    {
        long exp = n;

        if (exp < 0)
        {
            x = 1 / x;
            exp = -exp;
        }

        double result = 1;

        while (exp > 0)
        {
            if (exp % 2 == 1)
            {
                result *= x;
            }

            x *= x;
            exp /= 2;
        }

        return result;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        double x = 5.0;
        int n = 4;
        double result = solution.MyPow(x, n);
        Console.WriteLine($"{x}^{n} = {result}");
    }
}