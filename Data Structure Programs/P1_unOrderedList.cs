using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class P1_unOrderedList
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

        public class List<T>
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
        }

        
        List<string> linkedList = new List<string>();

        public void unOrderedist()
        {
            string text = "white,black,blue,green,red,orange,brown,yellow,pink,magenta";
            string[] strArr = text.Split(',');

            

            foreach (var str in strArr)
            {
                linkedList.add(str);
            }

            linkedList.printList();

            Console.Write("\n\n\nEnter a value to be searched:  ");
            string element = Console.ReadLine();
            int index = linkedList.SearchElement(element);

            if (index == -1)
            {
                Console.Write("\nElement not found\n");
                Console.WriteLine("Adding {0} into list\n", element);
                linkedList.add(element);
               
            }
            else
            {
                Console.Write("\nElement found at position {0}\nRemoving {1} from list", index,element);
                linkedList.deleteNode(element);
            }

            Console.WriteLine("\nUpdated list: \n");
            linkedList.printList();
        }
    }
}
