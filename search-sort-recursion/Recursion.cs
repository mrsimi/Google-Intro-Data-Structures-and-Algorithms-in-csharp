using System.Collections.Generic;

namespace search_sort_recursion
{
    public class Recursion
    {
        public int getNext(int value)
        {
            if(value == 0)
            {
                return 0;
            }
            else if(value == 1)
            {
                return 1;
            }
            else 
            {
                return (getNext(value-1) + getNext(value-2));
            }
        }

        public List<int> CalculateFibs(int size)
        {
            var result = new List<int>();
            for (int i = 0; i < size; i++)
            {
                int value = getNext(i);
                System.Console.Write(value + "\t");
                result.Add(value);
            }

            return result;
        }
    }
}