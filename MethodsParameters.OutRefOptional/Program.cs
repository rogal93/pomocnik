using System;

namespace MethodsParameters.OutRefOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b;                                //przy out b nie musi miec przypisanej wartosci
            a = ReturnTwoNumbersOUT(a, out b);
            Console.WriteLine("Zabawy z out\na:" + a + "\nb:" + b);

            int c = a;                            //przy ref c musi byc definiowane
            a = ReturnTwoNumbersREF(a, ref c);
            Console.WriteLine("\nZabawy z ref\na:" + a + "\nc:" + c);

            string d = "Ludzie, pomozcie!";
            Console.WriteLine("\nZabawy z argumentem opcjonalnym:");
            WithOptionalArg();                    //domyslna wartosc argumentu
            WithOptionalArg(d);                   //podanie argumentu
            WithOptionalArg(help: "No pomozcie!");//inne podanie argumentu

            Console.ReadKey();
        }

        //Zmieniam a i nadaje wartosc b
        static int ReturnTwoNumbersOUT(int a, out int b)
        {
            a++;
            b = a;
            return a;
        }

        //Zmieniam a i c
        static int ReturnTwoNumbersREF(int a, ref int c)
        {
            a++;
            c++;
            return a;
        }

        //argument z wartoscia domyslna
        static void WithOptionalArg(string help="POMOCY!!!")
        {
            Console.WriteLine(help);
        }
    }
}
