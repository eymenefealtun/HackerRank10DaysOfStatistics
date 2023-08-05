using System;

namespace Day_05
{
    internal class GeometricDistribution1
    {
        public static void Execute()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            double probabilityOfDefectiveProduct = (double)1 / (double)3;
            double probabilityOfNormalProduct = (double)2 / (double)3;

            double result = 1;
            for (int i = 0; i < 4; i++)
                result *= probabilityOfNormalProduct;

            result *= probabilityOfDefectiveProduct;

            Console.WriteLine(Math.Round(result, 3));
            Console.ReadLine();
        }


        static double Binomial(double x, double n, double p)
        {
            double f = Factorial(n) / (Factorial(n - x) * Factorial(x));

            return (f * Math.Pow(p, x) * Math.Pow((1 - p), (n - x)));
        }

        static int Factorial(double n)
        {
            if (n < 2)
                return 1;
            return ((int)(Factorial(n - 1) * n));
        }
    }
}
