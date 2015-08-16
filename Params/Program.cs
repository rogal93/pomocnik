using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "poniedzialek", "wtorek", "sroda" };
            Write(days);
            Console.ReadKey();
        }

        //argumenty w params
        static void Write(params string[] days)
        {
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
