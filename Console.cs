using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre!");
            int init1 = Convert.ToInt32(Console.ReadLine());

            if (init1 / 2 == 2)
            {
                Console.WriteLine("C'est paire");
            }
            else
            {
                Console.WriteLine("Fils de pute");
            }
        }
    }
}
