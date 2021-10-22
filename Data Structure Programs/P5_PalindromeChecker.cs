using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class P5_PalindromeChecker
    {

		class Node
		{
			public char data;
			public Node next;
			public Node pre;

			internal static Node node(char data)
			{
				Node temp = new Node();
				temp.data = data;
				temp.next = null;
				temp.pre = null;

				return temp;
			}
		}


		class Deque
        {
			Node front;
			Node rear;
			int size = 0;

            public Deque()
            {
				front = rear = null;
				size = 0;
            }

			internal bool isEmpty()
            {
				return (front == null);
            }

			internal int dequeSize()
            {
				return size;
            }

			internal void addFront(char item)
            {
				Node temp = Node.node(item);

				if(temp == null)
                {
					Console.WriteLine("OverFlow");
				}
                else
                {
					if(front == null)
                    {
						front = rear = temp;
                    }
                    else
                    {
						temp.next = front;
						front.pre = temp;
						front = temp;
                    }

					size++;
                }
            }

			internal void addRear(char item)
            {
				Node temp = Node.node(item);

				if (temp == null)
				{
					Console.WriteLine("OverFlow");
				}
				else
				{
					if (front == null)
					{
						front = rear = temp;
					}
					else
					{
						temp.next = rear;
						rear.next = temp;
						rear = temp;
					}
					size++;
				}
			}

			internal char removeFront()
            {
				char value = '0';
                if (isEmpty())
                {
					Console.WriteLine("Underflow");
				}
                else
                {
					Node temp = front;
					value = front.data;
					front = front.next;
					

					if (front == null)
						rear = null;
					else
						front.pre = null;

					size--;
				}

				return value;
            }


			internal char removeRear()
			{
				char value = '0';
				if (isEmpty())
				{
					Console.WriteLine("Underflow");
				}
				else
				{
					Node temp = rear;
					value = rear.data;
					rear = rear.pre;


					if (rear == null)
						front = null;
					else
						rear.next = null;

					size--;
				}

				return value;
			}

			public void printList()
			{
				Node temp = front;
				if (temp == null)
				{
					Console.WriteLine("Empty");
					return;
				}
				while (temp != null)
				{
					Console.Write(temp.data + " ");
					temp = temp.next;
				}
			}
		}

		public void Palindrome()
        {
			Console.Write("Enter a string:   ");
			string str = Console.ReadLine();
			char[] arr = str.ToCharArray();

			

			Deque q = new Deque();

			foreach(var x in arr)
            {
				q.addFront(x);
            }
			

			bool flag = false;

			while (q.dequeSize() > 1)
			{
				if (q.removeFront() == q.removeRear())
				{
					flag = true;
					break;
				}
			}

			if (flag)
			{
				Console.WriteLine("\n{0} is a palindrome",str);
			}
			else
			{
				Console.WriteLine("\n{0} is not a palindrome", str);
			}


		}

	}
}
