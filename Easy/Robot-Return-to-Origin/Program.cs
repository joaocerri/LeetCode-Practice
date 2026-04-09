public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;

        foreach (char c in moves)
        {
            if (c == 'R') x++;
            else if (c == 'L') x--;
            else if (c == 'U') y++;
            else y--;
        }

        return x == 0 && y == 0;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string moves = "UDLR";
        bool result = solution.JudgeCircle(moves);
        Console.WriteLine(result);

        moves = "UDDRRLU";
        result = solution.JudgeCircle(moves);
        Console.WriteLine(result);
    }
}
