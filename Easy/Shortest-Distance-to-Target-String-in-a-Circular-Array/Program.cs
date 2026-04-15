public class Solution
{
    public int ClosestTarget(string[] words, string target, int startIndex)
    {
        int distance = -1;
        int minDistance = int.MaxValue;
        bool found = false;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == target)
            {
                found = true;
                distance = i - startIndex;
                distance = distance < 0 ? -distance : distance;
                if (distance > words.Length / 2)
                    distance = words.Length - distance;
                if (minDistance > distance)
                    minDistance = distance;
            }
        }
        if (!found) minDistance = -1;

        return minDistance;
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        string[] words = { "hello", "i", "am", "leetcode", "hello" };
        string target = "hello";
        int startIndex = 1;
        int result = solution.ClosestTarget(words, target, startIndex);
        Console.WriteLine(result); 
    }
}