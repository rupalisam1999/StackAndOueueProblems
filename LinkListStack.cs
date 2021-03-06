using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblems
{
    class LinkedListStack
    {
        public Node top;

       
        public void  LinkListStack()
        {
            this.top = null;
        }

      
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value);
        }
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n is in the top of stack = " + this.top.data);
        }

       
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty \n deletion is not possible");
            }
            Console.WriteLine("\n Pop out elememnt is = " + this.top.data);
            this.top = this.top.next;
        }

       
        internal void isEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
            Console.WriteLine("Stack is empty");
        }


        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Inserted into the stack Successfully = " + temp.data);
                temp = temp.next;
            }
        }
    }
}
    

