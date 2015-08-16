using System;

namespace _2.ClassAndStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            DogClass klasowy1 = new DogClass();
            DogClass klasowy2 = klasowy1;
            klasowy2.Name = "Burek";

            //Referencja jest caly czas do jednego miejsca w pamieci.
            Console.WriteLine("Klasowe:");
            Console.WriteLine(klasowy1.ToString());
            Console.WriteLine(klasowy2.ToString());

            DogStruct strukturowy1 = new DogStruct("Misiek", "kundel");
            DogStruct strukturowy2 = strukturowy1;
            strukturowy2.Name = "Burek";

            //Typ wartosciowy dla kazdego osobno.
            Console.WriteLine("\nStrukturowe:");
            Console.WriteLine(strukturowy1.ToString());
            Console.WriteLine(strukturowy2.ToString());

            Console.ReadKey();
        }
    }

    #region klasa Dog
    public class DogClass
    {
        public string Name;
        public string Race;

        public DogClass()
        {
            Name = "Misiek";
            Race = "kundel";
        }

        public DogClass(string name, string race)
        {
            Name = name;
            Race = race;
        }

        public override string ToString()
        {
            return Race + " o imieniu " + Name;
        }
    }
    #endregion

    #region struktura Dog
    public struct DogStruct
    {
        public string Name;
        public string Race;

        //NIE MOZNA W STRUKTURACH TWORZY KOSTRUKTOROW BEZPARAMETROWYCH
        //public DogStruct() { }

        public DogStruct(string name, string race)
        {
            Name = name;
            Race = race;
        }

        public override string ToString()
        {
            return Race + " o imieniu " + Name;
        }
    }
    #endregion
}
