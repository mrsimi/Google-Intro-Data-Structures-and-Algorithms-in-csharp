using System;
using List_Based_Collection;

namespace list_based_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(9);
            myQueue.Enqueue(10);

            myQueue.printQueue();

            myQueue.Deque();
            
            Console.WriteLine("after deque");
            myQueue.printQueue();
        }
    }
}
