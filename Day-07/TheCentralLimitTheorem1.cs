using System;

namespace Day_07
{
    internal class TheCentralLimitTheorem1
    {
        internal static void Execute()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            double e = 2.71828;

            int maxWeightCanElevatorHandle = 9800;
            int numberOfBoxesInTheCargo = 49;
            int meanWeightOfCargoBoxes = 205;
            int standardDeviation = 15;


            // u1--> n x u
            // q1 --> Root(n) x q
            double u1 = numberOfBoxesInTheCargo * meanWeightOfCargoBoxes;
            double q1 = Math.Sqrt(numberOfBoxesInTheCargo) * standardDeviation;

            double result = CumulativeDistribution(u1, q1, maxWeightCanElevatorHandle); // Probability that the elevator can successfully transport all 49 boxes.

            Console.WriteLine(Math.Round(result, 4));
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
