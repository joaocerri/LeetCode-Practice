public class Solution
{
    public bool HasSameDigits(string s)
    {

        while (s.Length > 2)
        {
            string newstring = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                int sum = (s[i] - '0') + (s[i + 1] - '0');
                newstring += $"{(sum) % 10}";
            }
            s = newstring;
        }
        return s[0] == s[1];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "1231";
        bool result = solution.HasSameDigits(s);
        Console.WriteLine($"Input: {s}, Output: {result}");
    }
}