using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        StringBuilder sb = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            sb.Append(sum % 2);
            carry = sum / 2;
        }

        char[] chars = sb.ToString().ToCharArray();
        System.Array.Reverse(chars);

        return new string(chars);
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string a = "1010";
        string b = "1011";
        string result = solution.AddBinary(a, b);
        Console.WriteLine(result);
    }
}