using System;

namespace _5.VirtualAndAbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = new Figura(); nie mozna tworzyc obiektow klasy abstrakcyjnej!!!
        }
    }

    #region virtual method example

    //nie musi byc virtual zeby miec takie metody
    public class Dog
    {
        public virtual void Bark()
        {
            Console.WriteLine("hau hau");
        }
    }

    public class NoisyDog : Dog
    {
        //moge ale nie musze implementowac na nowo
        public override void Bark()
        {
            for (int i = 0; i < 3; i++)
            {
                base.Bark();
            }
        }
    }

    #endregion

    #region abstract method example

    public abstract class Figura
    {
        public abstract double Pole();
    }

    public class Kwadrat : Figura
    {
        public double dlugoscBoku;

        //trzeba ta metode zaimplementowac tutaj
        public override double Pole()
        {
            return dlugoscBoku * dlugoscBoku;
        }
    }

    #endregion
}
