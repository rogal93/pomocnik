using System;

namespace _9.Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //rozne zapisy wyrazen lambda
            Predicate<int> p1 = value => value > 0;
            Predicate<int> p2 = (value) => value > 0;
            Predicate<int> p3 = (int value) => value > 0;
            Predicate<int> p4 = value => { return value > 0; };
            Predicate<int> p5 = (value) => { return value > 0; };
            Predicate<int> p6 = (int value) => { return value > 0; };

            //przyklad bezparametrowego wyrazenia lambda
            Func<bool> isAfternoon = () => DateTime.Now.Hour > 12;
        }
    }
}
