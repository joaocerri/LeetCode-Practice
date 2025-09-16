public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> contador = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (contador.ContainsKey(c))
                contador[c]++;

            else
                contador[c] = 1;
        }

        foreach (char c in t)
        {
            if (!contador.ContainsKey(c))
                return false;
            contador[c]--;

            if (contador[c] < 0)
                return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "anagram";
        string t = "nagaram";
        bool result = solution.IsAnagram(s, t);
        Console.WriteLine($"Is \"{s}\" an anagram of \"{t}\"? {result}");
    }
}