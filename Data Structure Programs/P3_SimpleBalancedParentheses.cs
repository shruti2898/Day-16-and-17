using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class P3_SimpleBalancedParentheses
    {
        public void checkBalancedParentheses()
        {
            Stack stack = new Stack();

            string str = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            char[] arr = str.ToCharArray();

            foreach(var x in arr)
            {
                if (x == '(' )
                {
                    stack.push(x);
                }
                else if (x == ')')
                {
                    stack.pop();
                }
            }

            if (stack.isEmpty())
            {
                Console.WriteLine("Arithmetic Expression {0} is balanced",str);
            }
            else
            {
                Console.WriteLine("Arithmetic Expression {0} is not balanced",str);
                stack.display();
            }
            
        }
    }

    class Stack
    {
        class Node
        {
            public char data;
            public Node next;
        }

        private Node top;
        public Stack()
        {
            this.top = null;
        }

        public void push(char item)
        {
            Node temp = new Node();

            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            temp.data = item;
            temp.next = top;
            top = temp;

        }

        public void pop()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            top = top.next;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public void display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}", temp.data);

                    temp = temp.next;
                }
            }
        }
    }
}
