public class Solution
{
    public string IntToRoman(int num)
    {
        int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int i = 0;
        System.Text.StringBuilder resposta = new System.Text.StringBuilder();

        while (num > 0)
        {
            if (num >= valores[i])
            {
                resposta.Append(simbolos[i]);
                num -= valores[i];
            }
            else
                i++;
        }
        return resposta.ToString();
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int numero = 1994;
        string resultado = solution.IntToRoman(numero);
        System.Console.WriteLine($"O número {numero} em algarismos romanos é: {resultado}");
    }
}