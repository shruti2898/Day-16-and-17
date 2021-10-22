using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class P2_OrderedList
    {
        class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T data)
            {
                this.data = data;
                next = null;
            }
        }

        public class List<T> where T : IComparable<T>
        {
            Node<T> head;

            internal List()
            {
                head = null;
            }

            internal void add(T data)
            {
                Node<T> node = new Node<T>(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node<T> temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }

                //Console.WriteLine("{0} inserted into the linked list\n", node.data);
            }

            internal void printList()
            {
                Node<T> temp = head;
                if (temp == null)
                {
                    Console.WriteLine("Linked list is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }

            internal int SearchElement(T value)
            {
                Node<T> temp = head;
                int i = 0;
                while (temp != null)
                {
                    i++;
                    if (value.Equals(temp.data))
                    {
                        return i;
                    }
                    temp = temp.next;
                }
                return -1;
            }

            internal void deleteNode(T key)
            {

                Node<T> temp = head;
                Node<T> prev = null;

                if (temp != null && temp.data.Equals(key))
                {
                    head = temp.next;
                    return;
                }
                while (temp != null && !temp.data.Equals(key))
                {
                    prev = temp;
                    temp = temp.next;
                }

                if (temp == null)
                    return;

                prev.next = temp.next;
            }

            internal void sortList()
            {

                Node<T> currentNode = head;
                Node<T> currentNext = null;

                T temp;

                if (head == null)
                {
                    return;
                }
                else
                {
                    while (currentNode != null)
                    {
                        currentNext = currentNode.next;

                        while (currentNext != null)
                        {
                           
                            if (currentNode.data.CompareTo(currentNext.data) > 0)
                            {
                                temp = currentNode.data;
                                currentNode.data = currentNext.data;
                                currentNext.data = temp;
                            }

                            currentNext = currentNext.next;
                        }
                        currentNode = currentNode.next;
                    }
                }
            }
        }

        public void Orderedist()
        {
            string text = "10,5,7,1,6,9,4,2,3,8";
            string[] strArr = text.Split(',');

            int[] arr = new int[strArr.Length];
            for (int i=0; i< arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(strArr[i]);
            }

            List<int> linkedList = new List<int>();

            foreach (var x in arr)
            {
                linkedList.add(x);
            }
            Console.Write("List: ");
            linkedList.printList();
            Console.Write("\n\nSorted List: ");
            linkedList.sortList();
            linkedList.printList();
            Console.Write("\n\n\nEnter a value to be searched:  ");
            int element = Convert.ToInt32(Console.ReadLine());
             
            int index = linkedList.SearchElement(element);

            if (index == -1)
            {
                Console.Write("\nElement not found\n");
                Console.WriteLine("Adding {0} into list\n", element);
                linkedList.add(element);
            }
            else
            {
                Console.Write("\nElement found at position {0}\nRemoving {1} from list", index, element);
                linkedList.deleteNode(element);
            }

            Console.WriteLine("\nUpdated list: \n");
            linkedList.printList();
        }
    }
}
