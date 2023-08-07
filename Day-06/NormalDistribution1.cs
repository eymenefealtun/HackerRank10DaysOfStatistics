using System;

namespace Day_06
{
    internal class NormalDistribution1
    {
        internal static void Execute()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int mean = 20;
            int standardDeviation = 2;

            //prob of less than 19.5
            var result1 = CumulativeDistribution(mean, standardDeviation, 19.5);

            //prob of between 20 and 22
            var result2 = CumulativeDistribution(mean, standardDeviation, 22) - CumulativeDistribution(mean, standardDeviation, 20);

            Console.WriteLine(Math.Round(result1, 3));
            Console.WriteLine(Math.Round(result2, 3));
            Console.ReadLine();
        }

        static double CumulativeDistribution(double m, double s, double x)
        {
            double z = (x - m) / (s * Math.Sqrt(2));
            return (1 + erf(z)) / 2;
        }

        static double erf(double x)
        {
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = x < 0 ? -1 : 1;
            x = Math.Abs(x);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return sign * y;
        }
    }
}
