
namespace _2.OperatorsPlusAndConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag worek = new Bag(10);
            Bag drugiWorek = new Bag(14);

            //sumowanie
            Bag sumaWorkow = worek + drugiWorek;
            //z inta na bag
            int liczbaRzeczy = (int)worek;
            //z bag na int
            Bag nowyWorek = (Bag)15;
        }
    }

    public class Bag
    {
        public int Things;
        
        public Bag(int things)
        {
            Things = things;
        }

        //Definicja operatora dodawania
        public static Bag operator +(Bag bag1, Bag bag2)
        {
            return new Bag(bag1.Things + bag2.Things);
        }

        //konwersja z bag na int i odwrotnie
        public static explicit operator int(Bag bag)
        {
            return bag.Things;
        }
        public static explicit operator Bag(int value)
        {
            return new Bag(value);
        }

    }
}
