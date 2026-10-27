using System;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            // ---- in ----
            int value = 7;
            Console.WriteLine("=== in ===");
            Console.WriteLine($"A(in value)       = {Methods.A(in value)}   (default multiplier = 2)");
            Console.WriteLine($"A(in value, 5)    = {Methods.A(in value, 5)}");
            Console.WriteLine($"value after A     = {value}   (unchanged)");

            // ---- out ----
            Console.WriteLine("\n=== out ===");
            Methods.B(4, 6, out int s, out int p);
            Console.WriteLine($"B(4, 6) -> sum = {s}, product = {p}");

            // ---- ref ----
            Console.WriteLine("\n=== ref ===");
            int counter = 5;
            Console.WriteLine($"counter before    = {counter}");
            Methods.C(ref counter);
            Console.WriteLine($"after C(ref)      = {counter}   (default step = 10)");
            Methods.C(ref counter, 100);
            Console.WriteLine($"after C(ref, 100) = {counter}");

            // ---- params ----
            Console.WriteLine("\n=== params ===");
            Console.WriteLine($"SumValues()                = {Methods.SumValues()}");
            Console.WriteLine($"SumValues(5)               = {Methods.SumValues(5)}");
            Console.WriteLine($"SumValues(1, 2, 3)         = {Methods.SumValues(1, 2, 3)}");
            Console.WriteLine($"SumValues(10, 20, 30, 40)  = {Methods.SumValues(10, 20, 30, 40)}");
            int[] arr = { 3, 6, 9, 12 };
            Console.WriteLine($"SumValues(arr)             = {Methods.SumValues(arr)}");
        }
    }
}
