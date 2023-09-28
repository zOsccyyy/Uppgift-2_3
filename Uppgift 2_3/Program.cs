using System;

namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Hur länge ska du ha bilen?");
            string längd = Console.ReadLine();
            Console.WriteLine("Hur många kilometer ska du åka?");
            string kilometer = Console.ReadLine();
            int dagar = int.Parse(längd);
            int Km = int.Parse(kilometer);
            int kostnad_per_dag = (dagar - 1) * 500;
            int startavgift = +300;
            int Totallpris = kostnad_per_dag + startavgift + Km;                             
            Console.WriteLine(Totallpris + " Kr ");
        }
    }
}


