using System;
using System.Collections.Generic;

namespace _3.Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            //przyklad uzycia
            foreach (int i in Numbers(1, 7))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        //przyklad iteratora
        public static IEnumerable<int> Numbers(int start, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return start + i;
            }
        }
    }
}
