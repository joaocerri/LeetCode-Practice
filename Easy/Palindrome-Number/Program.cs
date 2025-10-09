namespace Program;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        int original = x;
        int invertido = 0;

        while (x > 0)
        {
            invertido = (invertido * 10) + x % 10;
            x = x / 10;
        }
        if (invertido == original)
            return true;

        else
            return false;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int numero = 121;
        bool resultado = solution.IsPalindrome(numero);
        Console.WriteLine($"O número {numero} é um palíndromo: {resultado}");
    }
}

