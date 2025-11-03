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
            ListNode head = new ListNode(list.First()); //specifies which is the head
            ListNode current = head;// clarifies on what node you currently are which is the head at start
            foreach (var item in list.Skip(1)) 
            {
                current.next = new ListNode(item);//the next of the current is the one being specified
                current = current.next; //moves to the next node of the linked list
            }
            Thread.Sleep(100);
            PrintLinkedList(head,list);
        
            while (true)
            {
                          

                Console.Write(""""
                    1.Add to front
                    2.Add to the end
                    3.Add node at point
                    4.Reverse List
                    5.Exit

                    Answer:
                    """");

                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            AddNewHead(head, list);
                            break;
                        case 2:
                            AddNodeAtEnd(head, list);
                            break;
                        case 3:
                            AddNodeAtPoint(head, list);
                            break;
                        
                          

                        case 4:
                            Console.Clear();
                        ReverseList(head,list);
                        
                        break;

                            case 6:
                            Environment.Exit(0);
                            break;

                        
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

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
                Console.WriteLine($"---Reached end of the list---\n");
                Console.WriteLine($"Number of nodes: {list.Count()}\n");
                

            }
        }


        //private static void PrintLinkedListReverseOption(ListNode head, LinkedList<int> list)
        //{
        //    Thread.Sleep(100);
        //    if (head == null)
        //    {
        //        Console.WriteLine("Linked List is empty");
        //    }

        //    else
        //    {
        //        while (head != null)
        //        {
        //            Thread.Sleep(100);
        //            Console.WriteLine(head.val);
        //            head = head.next;
        //        }

        //    }
        //}
        private static void ReverseList(ListNode head, LinkedList<int> list)
        {
            LinkedList<int> newList = new LinkedList<int> ();
            var revList=list.Reverse();
            foreach(int item in revList)
            {
                newList.AddLast(item);
            }
            ListNode lastNode = new ListNode(newList.First());
            ListNode current= lastNode;

            foreach (int item in newList.Skip(1)) 
            {
                current.next= new ListNode(item);
                current= current.next;
            }
            
            Console.Write("Reversing");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine();

            PrintLinkedList(lastNode, list);

            list.Clear();
            foreach(var item in newList)
            {
                list.AddLast(item);
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
            Console.WriteLine($"Added {newHeadValue} to the front of list\n");
            PrintLinkedList(head, list);
        }
        private static void AddNodeAtEnd(ListNode head, LinkedList<int> list)
        {
            Console.WriteLine($"What number would you like to add to the end of the list\n");
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
        private static void AddNodeAtPoint(ListNode head, LinkedList<int> list)
        {
            Console.WriteLine("What place do you want this number to be?");
            if (!int.TryParse(Console.ReadLine(), out int place) || place < 1)
            {
                Console.WriteLine("Invalid place.");
                return;
            }

            Console.WriteLine("What do you want the number to be");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid number.");
                return;
            }
                        
            if (list.Count == 0 || place <= 1)
            {
                list.AddFirst(number);
            }
            else if (place > list.Count)
            {
                list.AddLast(number);
            }
            else
            {
                var node = list.First;
                for (int i = 1; i < place; i++)
                {
                    node = node.Next;
                }
                
                list.AddBefore(node, number);
            }

            
            if (list.Count == 0)
            {
                head = null;
            }
            else
            {
                head = new ListNode(list.First.Value);
                ListNode current = head;
                foreach (var item in list.Skip(1))
                {
                    current.next = new ListNode(item);
                    current = current.next;
                }
            }

            Console.Clear();
            Console.WriteLine($"Added {number} at position {Math.Min(place, list.Count)}\n");
            PrintLinkedList(head, list);
        }



    }
}
