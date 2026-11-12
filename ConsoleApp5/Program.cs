using System;

namespace vaje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi polmer kroga: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Krog k1 = new Krog(r);

            Console.WriteLine("Obseg kroga je: " + k1.Obseg());
            Console.WriteLine("Ploscina kroga je: " + k1.Ploscina());
        }
    }
}