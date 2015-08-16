using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new Observable();

            Observer obs1 = new Observer("Krzysiek");
            Observer obs2 = new Observer("Witek");

            //dodaje obserwatorow do zdarzenia
            observable.SomethingHappened += obs1.HandleEvent;
            observable.SomethingHappened += obs2.HandleEvent;

            observable.DoSomething();

            Console.ReadKey();
        }
    }

    //obserwowany, ktory wykonuje jakies zdarzenie
    public class Observable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething()
        {
            EventHandler handler = SomethingHappened;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }

    //obserwujacy obslugujacy zdarzenie
    public class Observer
    {
        private string name;

        public Observer(string name)
        {
            this.name = name;
        }

        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Something happened to {0} - zauważył {1}", sender, name);
        }
    }
}
