using System;
using System.IO;

namespace _5.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader r = new StreamReader(@"C:\Temp\File.txt"))
                {
                    while (!r.EndOfStream)
                    {
                        Console.WriteLine(r.ReadLine());
                    }
                }
            }
            catch (FileNotFoundException x) //ten wyjatek dziedziczy po IOException
            {
                Console.WriteLine("Nie udalo sie znalezc pliku: {0}", x.FileName);
            }
            catch (IOException x)
            {
                Console.WriteLine("Blad wejscia-wyjscia: {0}", x.Message);
            }
            finally //to sie zawsze wykona po try'u, nawet jak wyrzuci exception
            {
                Console.WriteLine("To sie zawsze wykona");
            }

            //uzycie zwrocenia wyjatku
            Wypisz("");
        }

        static void Wypisz(string tekst)
        {
            if (tekst == "")
            {
                //rzucenie wyjatku
                throw new ArgumentException("pusty tekst");
            }
        }
    }
}
