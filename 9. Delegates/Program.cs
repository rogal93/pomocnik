using System;

namespace _9.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func i Action
            //klasa z metodami do przekazania do delegatow
            Calculator calc = new Calculator();

            //delegaty w formie funkcji przyjmujacej 2 argumenty double i zwracajace wynik double
            Func<double, double, double> add = calc.Add;
            Func<double, double, double> sub = calc.Substract;

            //akcja do wypisywania wynikow
            Action<double, double, Func<double, double, double>> writeResults = calc.WriteResultToConsole; 

            //policzenie poprzez przekazanie metody liczacej delegatem do osoby, ktora nie potrafi liczyc
            Console.WriteLine("5 + 10");
            writeResults(5, 10, add);

            Console.WriteLine("5 - 10");
            writeResults(5, 10, sub);
            #endregion

            #region Predykat<double>
            //klasa z metodami do przekazania
            ComparerWithSomeNumbers comparer = new ComparerWithSomeNumbers();

            //predykat zwraca boola
            Predicate<double> isGreaterThanZero = comparer.IsGreaterThanZero;
            Predicate<double> isGreaterThanTen = comparer.IsGreaterThanTen;

            Console.WriteLine("9 jest wieksze od 0? {0}\n9 jest wieksze od 10? {1}", 
                isGreaterThanZero(9), isGreaterThanTen(9));
            #endregion

            Console.ReadKey();
        }
    }

    #region Func i Action
    //klasa do funkcji liczacych
    public class Calculator
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public double Substract(double value1, double value2)
        {
            return value1 - value2;
        }

        //do Action bo nie zwraca nic
        public void WriteResultToConsole(double value1, double value2, Func<double, double, double> operation)
        {
            Console.WriteLine("Wynik oparacji: {0}", operation(value1, value2));
        }
    }
    #endregion

    #region Predykat<double>
    //klasa do predykatow<double>
    public class ComparerWithSomeNumbers
    {
        public bool IsGreaterThanZero(double value)
        {
            return value > 0;
        }

        public bool IsGreaterThanTen(double value)
        {
            return value > 10;
        }
    }
    #endregion
}
