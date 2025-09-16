public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maior_lucro = 0;
        int menor_preco = int.MaxValue;

        foreach (int preco in prices)
        {
            if (preco < menor_preco)
            {
                menor_preco = preco;
            }
            if (maior_lucro < preco - menor_preco)
            {
                maior_lucro = preco - menor_preco;
            }
        }
        return maior_lucro;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        int result = solution.MaxProfit(prices);
        Console.WriteLine(result); 
    }
}