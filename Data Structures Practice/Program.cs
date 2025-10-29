
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data_Structures_Practice
{
    internal class Program
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
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(25);
            list.AddLast(3);
            list.AddLast(6);
            list.AddLast(5);
            ListNode head = new ListNode(list.First());
            ListNode current = head;
            foreach (var item in list.Skip(1))
            {
                current.next = new ListNode(item);
                current = current.next;
            }

            while (true)
            {
                Console.Write(""""
                    1.Add to front
                    2.Add to the end
                    3.Print List
                    Answer:
                    """");

                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.ReadLine();
                            AddNewHead(head, list);
                            break;
                        case 2:
                            
                            AddNodeAtEnd(head, list);
                            break;
                        case 3:
                            Console.Clear();
                            PrintLinkedList(head, list);
                            break;
                        
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }



        // Now head points to the head of the linked list

    

        private static void PrintLinkedList(ListNode head, LinkedList<int> list)
        {
            Thread.Sleep(100);
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }

            else
            {
                while (head != null)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(head.val);
                    head = head.next;
                }
                Console.WriteLine("\nReached the end of the list");
                Console.WriteLine("-------------------\n");
            }
         
                Console.WriteLine("Would you like to see the list in reverse?");

                Console.Write("""
                    1.Yes
                    2.No
                    =
                    """);

            int option = Convert.ToInt32(Console.ReadLine());
            
            
                try
                {

                    switch (option)
                    {
                        case 1:
                        Console.Clear ();
                            ReverseList(list);

                            break;
                        case 2:
                            Console.Clear();
                            return;

                        default:
                            Console.WriteLine("Incorrect answer");
                            PrintLinkedList(head, list);
                            break;


                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }




            }
       

        private static void ReverseList(LinkedList<int> list)
        {
            var newList = list.Reverse();
            ListNode lastNode = new ListNode(newList.First());
            ListNode current= lastNode;

            foreach (int item in newList.Skip(1)) 
            {
                current.next= new ListNode(item);
                current= current.next;
            }

            Thread.Sleep(100);
            if (lastNode == null)
            {
                Console.WriteLine("Linked List is empty");
            }

            else
            {
                Console.WriteLine("");
                while (lastNode != null)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(lastNode.val);
                    lastNode = lastNode.next;
                }
                Console.WriteLine("\nReached the end of the reversed list");
                Console.WriteLine("-------------------\n");
            }



        }

        private static void AddNewHead(ListNode head, LinkedList<int> list)
        {
            Console.WriteLine($"What number would you like to add to the front of list");
            int newHeadValue = Convert.ToInt32(Console.ReadLine());
            list.AddFirst(newHeadValue);

            head = new ListNode(list.First());
            ListNode current = head;
            foreach (var item in list.Skip(1))
            {
                current.next = new ListNode(item);
                current = current.next;
            }
            
            
            Console.Clear() ;
            Console.WriteLine($"Added {newHeadValue} to the front of list");
            PrintLinkedList(head, list);
        }

        private static void AddNodeAtEnd(ListNode head, LinkedList<int> list)
        {
            Console.WriteLine($"What number would you like to add to the end of the list");
            int newValue = Convert.ToInt32(Console.ReadLine());
            list.AddLast(newValue);
            head = new ListNode(list.First());
            ListNode current = head;
            foreach (var item in list.Skip(1))
            {
                current.next = new ListNode(item);
                current = current.next;
            }



            Console.Clear();
            Console.WriteLine($"Added {newValue} to the end of the list");
            PrintLinkedList(head, list);

        }




    }
}
