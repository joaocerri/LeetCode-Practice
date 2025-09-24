public class ListNode {
    public int val;
    public ListNode next;
     public ListNode(int val=0, ListNode next=null) 
    {
       this.val = val;
       this.next = next;
     }
}
 
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode atual = head;
        ListNode proximo = new ListNode();
        ListNode anterior = null;

        while (atual != null)
        {
            proximo = atual.next;
            atual.next = anterior;
            anterior = atual;
            atual = proximo;
        }
        return anterior;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ListNode node1 = new ListNode(1);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(3);
        ListNode node4 = new ListNode(4);
        ListNode node5 = new ListNode(5);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        Solution solution = new Solution();
        ListNode reversedHead = solution.ReverseList(node1);
        PrintList(reversedHead);
    }
    public static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}