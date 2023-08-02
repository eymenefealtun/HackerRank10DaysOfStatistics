using System;

namespace Day_05
{
    internal class BinomialDistribution1
    {
        public static void Execute()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] input = Console.ReadLine().Split(' ');

            float p = (float)(Convert.ToDouble(input[0]) / (Convert.ToDouble(input[0]) + Convert.ToDouble(input[1])));
            int n = 6;

            double result = Binomial(3, n, p) + Binomial(4, n, p) + Binomial(5, n, p) + Binomial(6, n, p);

            Console.WriteLine(Math.Round(result, 3));
            Console.ReadLine();
        }

        static int Factorial(double n)
        {
            if (n < 2)
                return 1;
            return ((int)(Factorial(n - 1) * n));
        }

        static double Binomial(double x, double n, double p)
        {
            double f = Factorial(n) / (Factorial(n - x) * Factorial(x));

            return (f * Math.Pow(p, x) * Math.Pow((1 - p), (n - x)));
        }
    }
}
