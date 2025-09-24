public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int area = 0;
        int esquerda = 0;
        int direita = height.Length - 1;

        while (esquerda < direita)
        {
            area = (direita - esquerda) * Math.Min(height[esquerda], height[direita]);

            if (area > maxArea)
                maxArea = area;

            if (height[esquerda] < height[direita])
                esquerda++;

            else
                direita--;
        }
        return maxArea;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int result = solution.MaxArea(height);
        Console.WriteLine(result); 
    }
}