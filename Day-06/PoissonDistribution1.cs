using System;

namespace Day_06
{
    internal class PoissonDistribution1
    {
        internal static void Execute()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            double e = 2.71828;
            double x = 5;
            double lambda = 2.5;

            Console.WriteLine(Math.Round(Poisson(e, x, lambda), 3));
            Console.ReadLine();
        }

        static int Factorial(double n)
        {
            if (n < 2)
                return 1;
            return ((int)(Factorial(n - 1) * n));
        }

        static double Poisson(double e, double x, double lambda)
        {
            return (Math.Pow(lambda, x) * Math.Pow(e, -lambda)) / Factorial(x);
        }
    }
}
