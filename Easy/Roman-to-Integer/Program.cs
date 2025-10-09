public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> roman = new Dictionary<char, int>();

        int valor = 0;
        int valorAnterior = 0;

        roman.Add('I', 1);
        roman.Add('V', 5);
        roman.Add('X', 10);
        roman.Add('L', 50);
        roman.Add('C', 100);
        roman.Add('D', 500);
        roman.Add('M', 1000);

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int valorAtual = roman[s[i]];

            if (valorAtual < valorAnterior)
            {
                valor -= valorAtual;
            }
            else
            {
                valor += valorAtual;
            }

            valorAnterior = valorAtual;
        }
        return valor;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "MCMXCIV";
        int result = solution.RomanToInt(s);
        Console.WriteLine(result); 
    }
}