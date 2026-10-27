using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            Matrix m = new Matrix(5, -20, 50);

            Console.WriteLine("Matrix 5x5, values in [-20, 50]:");
            m.ShowMatrix();
            Console.WriteLine($"Odd numbers count: {m.CountOdd()}");
        }
    }
}
