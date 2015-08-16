using System;

using System.Resources;
using System.Threading;

namespace _11.Resx
{
    class Program
    {
        static void Main(string[] args)
        {
            //pobieranie zasobow w trakcie programu
            var rm = new ResourceManager("_11.Resx.MyResources", typeof(Program).Assembly);
            string colText = rm.GetString("ColString");

            Console.WriteLine("U nas kolor to: " + colText);

            //wymuszenie uzycia ustawien kulturowych innych niz domyslne
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
            colText = rm.GetString("ColString");

            Console.WriteLine("U nas kolor to: " + colText);

            Console.ReadKey();
        }
    }
}
