using System;

namespace _2.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCard deck = DeckOfCard.Clubs;
            Console.WriteLine((int)deck);
            Console.ReadKey();
        }
    }

    //nadaje wartosci liczbowe kazdemu wyliczeniu
    public enum DeckOfCard
    {
        Hearts = 1,
        Diamonds = 3,
        Clubs = 5,
        Spades = 18
    }
}
