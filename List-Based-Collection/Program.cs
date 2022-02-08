using System;
using List_Based_Collection;

namespace list_based_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> myList = new LinkedList<string>();
            myList.Append("ade");
            myList.Append("2");
            myList.Append("4");
            myList.InsertAt("5", 0);

            Console.WriteLine(myList.PrintList());
            // Console.WriteLine(myList.Count());
            // Console.WriteLine(myList.AtIndex(1));

            // myList.Remove(2);
            // Console.WriteLine("new count");
            Console.WriteLine(myList.Count());
        }
    }
}
