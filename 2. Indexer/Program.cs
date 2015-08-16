using System;

namespace _2.Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeNumbersOrZero trzyLiczbyLubZero = new ThreeNumbersOrZero(13, 16, 18);
            Console.WriteLine("[0] = {0}\n[1] = {1}\n[2] = {2}\nwszystko poza = {3}", trzyLiczbyLubZero[0], 
                trzyLiczbyLubZero[1], trzyLiczbyLubZero[2], trzyLiczbyLubZero[3]);
            Console.ReadKey();
        }
    }

    public class ThreeNumbersOrZero
    {
        private int first, second, third;

        //W tym miejscu definiuje sie dzialanie indeksatora
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return first;
                    case 1: return second;
                    case 2: return third;
                    default: return 0;
                }
            }
        }

        public ThreeNumbersOrZero(int first, int second, int third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
    }
}
