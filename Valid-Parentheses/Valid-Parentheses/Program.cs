using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> chaves = new Dictionary<char, char>();
        chaves.Add(')', '(');
        chaves.Add('}', '{');
        chaves.Add(']', '[');

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (chaves.ContainsKey(s[i]))
            {
                if (stack.Count == 0 || stack.Peek() != chaves[s[i]])
                {
                    return false;
                }
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        return stack.Count == 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        string input1 = "()";
        string input2 = "()[]{}";
        string input3 = "(]";
        string input4 = "([{}])";
        string input5 = "(((";

        Console.WriteLine($"\"{input1}\" é válido? {sol.IsValid(input1)}");
        Console.WriteLine($"\"{input2}\" é válido? {sol.IsValid(input2)}");
        Console.WriteLine($"\"{input3}\" é válido? {sol.IsValid(input3)}");
        Console.WriteLine($"\"{input4}\" é válido? {sol.IsValid(input4)}");
        Console.WriteLine($"\"{input5}\" é válido? {sol.IsValid(input5)}");
    }
}
