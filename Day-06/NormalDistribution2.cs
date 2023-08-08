using System;

namespace Day_06
{
    internal class NormalDistribution2
    {
        internal static void Execute()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int mean = 70;
            int standardDeviation = 10;

            //grade is higher than 80
            var result1 = 100 - CumulativeDistribution(mean, standardDeviation, 80); //after minus is equals to possibility of lower than 80. Thus, we subtracted this from 100;

            //grade is higher than and equals  60
            var result2 = 100 - CumulativeDistribution(mean, standardDeviation, 60); //after minus is equals to possibility of lower than 60. Thus, we subtracted this from 100;

            //grade is lower than 60
            var result3 = CumulativeDistribution(mean, standardDeviation, 60);

            Console.WriteLine(Math.Round(result1, 2));
            Console.WriteLine(Math.Round(result2, 2));
            Console.WriteLine(Math.Round(result3, 2));
            Console.ReadLine();
        }

        static double CumulativeDistribution(double m, double s, double x)
        {
            double z = (x - m) / (s * Math.Sqrt(2));
            //this 100 is here because we are asked for percentage
            return 100 * (1 + erf(z)) / 2;
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
