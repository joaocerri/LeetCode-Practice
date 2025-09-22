
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
       }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummyHead = new ListNode();
        var tail = dummyHead;


        while (list1 != null && list2 != null)
        {
            if (list1.val > list2.val)
            {
                tail.next = list2;
                list2 = list2.next;
            }
            else
            {
                tail.next = list1;
                list1 = list1.next;
            }
            tail = tail.next;
        }
        if (list1 == null)
            tail.next = list2;
        else
            tail.next = list1;

        return dummyHead.next;
    }
}

class Program
{
    static void Main(string[] args)
    {

        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);

        Solution solution = new Solution();
        ListNode mergedList = solution.MergeTwoLists(list1, list2);

        Console.WriteLine("Lista mesclada:");
        ListNode current = mergedList;
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null)
            {
                Console.Write(" -> ");
            }
            current = current.next;
        }
        Console.WriteLine();
    }
}