using System;

namespace Lab4
{
    static class Methods
    {
        // in — readonly reference
        public static int A(in int x, int multiplier = 2)
        {
            return x * multiplier;
        }

        // out — method must assign values
        public static void B(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        // ref — pass by reference, changes visible outside
        public static void C(ref int x, int step = 10)
        {
            x += step;
        }

        // params — variable number of arguments
        public static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
                sum += n;
            return sum;
        }
    }
}
