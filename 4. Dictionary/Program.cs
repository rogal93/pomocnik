using System;
using System.Collections.Generic;

namespace _4.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cyfry = new Dictionary<int, string>
            {
                {0, "zero"},
                {1, "jeden"},
                {2, "dwa"},
                {3, "trzy"},
                {4, "cztery"},
                {5, "piec"},
                {6, "szesc"},
                {7, "siedem"},
                {8, "osiem"},
                {9, "dziewiec"},
            };

            for (int i = 0; i < cyfry.Count; i++)
            {
                Console.WriteLine(cyfry[i]);
            }

            foreach (var item in cyfry)
            {
                Console.WriteLine("Klucz: {0}, Wartosc: {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
