using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return Height(root) != -1;
    }

    private int Height(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int leftHeight = Height(node.left);
        if (leftHeight == -1) return -1;

        int rightHeight = Height(node.right);
        if (rightHeight == -1) return -1;

        if (Math.Abs(leftHeight - rightHeight) > 1)
        {
            return -1;
        }

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        TreeNode balanced = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)
            ),
            new TreeNode(3)
        );

        TreeNode unbalanced = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(3,
                    new TreeNode(4),
                    null
                ),
                null
            ),
            null
        );

        Console.WriteLine($"Árvore balanceada? {sol.IsBalanced(balanced)}"); 
        Console.WriteLine($"Árvore desbalanceada? {sol.IsBalanced(unbalanced)}");
    }
}
