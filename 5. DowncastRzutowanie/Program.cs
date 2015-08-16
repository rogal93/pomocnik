
namespace _5.DowncastRzutowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraPlaska figura = new FiguraPlaska();

            //rzutowanie
            var czworokat = (Kwadrat)figura;

            //uzycie as przy rzutowaniu
            czworokat = figura as Kwadrat;

            //zabezpieczenie poprzez sprawdzenie czy figura jest kwadratem
            if (figura is Kwadrat)
            {
                czworokat = figura as Kwadrat;
            }
        }
    }

    public class FiguraPlaska
    {

    }

    public class Kwadrat : FiguraPlaska
    {

    }
}
