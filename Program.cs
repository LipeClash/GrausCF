using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     25       F-32      ");
            Console.WriteLine("    _____  = _______    ");
            Console.WriteLine("      5         9       ");
            Console.WriteLine("\n");
            Console.WriteLine("25°C Celsius em Farenheit é :");
            Console.WriteLine("\n");

            double F1 = 5 * 32;
            double F2 = 25 * 9;
            double F3 = F2 + F1;
            double F4 = F3 / 5;

            Console.WriteLine($"{F1}");
            Console.WriteLine($"{F2}");
            Console.WriteLine($"{F2} + {F1} = {F3}");
            Console.WriteLine($"{F3} / 5 = {F4} ");

            Console.WriteLine("\n");
            Console.WriteLine("  | 77°F |  ");
            Console.WriteLine("\n");

            Console.WriteLine("°C = 25");
            Console.WriteLine("25°C equivalem a 77°F");







            

            


        }
    }
}
