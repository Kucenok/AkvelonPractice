using System;

namespace Merge
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            if (list1 != null)
            {
                current.next = list1;
            }

            if (list2 != null)
            {
                current.next = list2;
            }

            return dummy.next;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine("Введите элементы первого списка через пробел:");
            string input1 = Console.ReadLine();
            ListNode list1 = ParseInput(input1);

            Console.WriteLine("Введите элементы второго списка через пробел:");
            string input2 = Console.ReadLine();
            ListNode list2 = ParseInput(input2);

            ListNode mergedList = solution.MergeTwoLists(list1, list2);

            Console.WriteLine("Объединенный список:");
            PrintList(mergedList);
        }

        private static ListNode ParseInput(string input)
        {
            string[] numStrings = input.Split(' ');
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            foreach (string numString in numStrings)
            {
                int num = int.Parse(numString);
                current.next = new ListNode(num);
                current = current.next;
            }

            return dummy.next;
        }

        private static void PrintList(ListNode head)
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
}
