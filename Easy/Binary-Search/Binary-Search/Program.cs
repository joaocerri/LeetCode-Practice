using System;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int inicio = 0;
        int fim = nums.Length - 1;
        int meio = 0;

        while (inicio <= fim)
        {
            meio = (inicio + fim) / 2;
            if (nums[meio] > target)
            {
                fim = meio - 1;
            }
            else if (nums[meio] < target)
            {
                inicio = meio + 1;
            }
            else
            {
                return meio;
            }
        }
        return -1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] array1 = { -1, 0, 3, 5, 9, 12 };
        int target1 = 9;

        int[] array2 = { -1, 0, 3, 5, 9, 12 };
        int target2 = 2;

        int resultado1 = sol.Search(array1, target1);
        int resultado2 = sol.Search(array2, target2);

        Console.WriteLine($"Índice do alvo {target1} no array1: {resultado1}");
        Console.WriteLine($"Índice do alvo {target2} no array2: {resultado2}");

    }
}
