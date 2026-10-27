using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Default N = 2:");
            Console.WriteLine($"  ToMultiplicate(5)      = {Multiplicator.ToMultiplicate(5)}");
            Console.WriteLine($"  ToMultiplicate(2.5)    = {Multiplicator.ToMultiplicate(2.5)}");
            Console.WriteLine($"  ToMultiplicate(\"ab\")   = {Multiplicator.ToMultiplicate("ab")}");

            Console.WriteLine("Explicit N:");
            Console.WriteLine($"  ToMultiplicate(5, 4)   = {Multiplicator.ToMultiplicate(5, 4)}");
            Console.WriteLine($"  ToMultiplicate(1.5, 3) = {Multiplicator.ToMultiplicate(1.5, 3)}");
            Console.WriteLine($"  ToMultiplicate(\"Hi\", 3) = {Multiplicator.ToMultiplicate("Hi", 3)}");

            Console.WriteLine($"  ToMultiplicate(x: 7, N: 5) = {Multiplicator.ToMultiplicate(x: 7, N: 5)}");
        }
    }
}
