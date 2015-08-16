using System;

namespace _2.CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "poniedzialek", "wtorek", "sroda" };
            string[] copyOfTwoDays = new string[3];

            //metoda do kopiowania tablicy
            Array.Copy(days, copyOfTwoDays, 2);

            for (int i = 0; i < copyOfTwoDays.Length; i++)
            {
                Console.WriteLine(copyOfTwoDays[i]);
            }
            Console.ReadKey();
        }
    }
}
