using System;
using System.Collections.Generic;

namespace WhereRestriction
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe sandal = new Shoe(10, "sandal");
            Shoe chodak = new Shoe(9, "chodak");
            
            //uzycie porownywacza
            GenericComparer<Shoe> porownywaczButow = new GenericComparer<Shoe>();
            int wynikPorownania = porownywaczButow.Compare(sandal, chodak);

            if (wynikPorownania > 0)
            {
                Console.WriteLine("Wiekszy jest sandal.");
            }
            else if (wynikPorownania < 0)
            {
                Console.WriteLine("Wiekszy jest chodak.");
            }
            else
            {
                Console.WriteLine("Buty sa rowne.");
            }
            Console.ReadKey();
        }
    }

    //klasa porownujaca
    public class GenericComparer<T> : IComparer<T> 
        where T: IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }

    //przykladowa klasa do porownan
    public class Shoe : IComparable<Shoe>
    {
        public int Size;
        public string Name;

        public Shoe(int size, string name)
        {
            Size = size;
            Name = name;
        }

        //metoda interfejsu
        public int CompareTo(Shoe other)
        {
            return Size - other.Size;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
