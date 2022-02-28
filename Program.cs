using System;

namespace StackAndQueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
             LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();
            linkedListStack.peek();
            linkedListStack.Display();
            linkedListStack.pop();
            linkedListStack.Display();
            linkedListStack.isEmpty();
            linkedListStack.Display();
            LinkListQueue linkListQueue = new LinkListQueue();
            linkListQueue.Enqueue(56);
            linkListQueue.Enqueue(30);
            linkListQueue.Enqueue(70);
            linkListQueue.Display();
            Console.WriteLine("\n After Deque remaining elements is = ");
            linkListQueue.Display();
            linkListQueue.Display();
        }

    }
}
