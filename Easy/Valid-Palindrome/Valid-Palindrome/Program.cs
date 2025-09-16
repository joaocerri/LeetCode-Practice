using System;
using System.Text;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        s = sb.ToString();
        int ponteiro_direito = s.Length - 1;
        int ponteiro_esquerdo = 0;

        while (ponteiro_esquerdo < ponteiro_direito)
        {
            if (s[ponteiro_direito] != s[ponteiro_esquerdo])
            {
                return false;
            }
            ponteiro_direito--;
            ponteiro_esquerdo++;
        }

        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        string input1 = "A man, a plan, a canal: Panama";
        string input2 = "race a car";

        Console.WriteLine($"\"{input1}\" é palíndromo? {sol.IsPalindrome(input1)}");
        Console.WriteLine($"\"{input2}\" é palíndromo? {sol.IsPalindrome(input2)}");

    }
}
