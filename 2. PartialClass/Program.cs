using System;

namespace _2.PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe but = new Shoe("Stinky");
            //wywoluje tostringa zeby sprawdzic, czy druga czesc jest wychwytywana
            Console.WriteLine(but);
            Console.ReadKey();
        }
    }

    //jedna czesc klasy
    public partial class Shoe
    {
        private string typeOfShoe;

        public Shoe(string typeOfShoe)
        {
            this.typeOfShoe = typeOfShoe;
        }
    }

    //druga czesc klasy
    public partial class Shoe
    {
        public override string ToString()
        {
            return typeOfShoe;
        }
    }
}
