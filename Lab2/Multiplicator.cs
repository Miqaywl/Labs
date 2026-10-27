using System;

namespace Lab2
{
    static class Multiplicator
    {
        public static int ToMultiplicate(int x, int N = 2)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        public static double ToMultiplicate(double x, int N = 2)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        public static string ToMultiplicate(string x, int N = 2)
        {
            string sum = "";
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }
    }
}
