public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        for (int i = triangle.Count - 2; i >= 0; i--)
        {
            for (int j = 0; j < triangle[i].Count; j++)
            {
                triangle[i][j] = triangle[i][j] + Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
            }
        }
        return triangle[0][0];
    }
}

public  class program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        IList<IList<int>> triangle = new List<IList<int>>
        {
            new List<int>       { 2 },
            new List<int>      { 3, 4 },
            new List<int>    { 6, 5, 7 },
            new List<int>   { 4, 1, 8, 3 }
        };
        int result = solution.MinimumTotal(triangle);
        Console.WriteLine(result); 
    }
}