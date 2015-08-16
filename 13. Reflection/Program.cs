using System;
using System.Collections.Generic;
using System.Reflection;

namespace _13.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzycie klasy Type do pobrania obiektu reprezentujacego podzespol
            Assembly me = typeof(Program).GetTypeInfo().Assembly;

            Console.WriteLine(me.FullName);

            //pobieranie obiketu Type przy uzyciu operatora typeof
            Type stringType = typeof(string);
            Type disposableType = typeof(IDisposable);

            //obiekty Type reprezentujace typy ogolne
            Type bound = typeof(List<string>);
            Type unbound = typeof(List<>);


            Console.ReadKey();
        }
    }
}
