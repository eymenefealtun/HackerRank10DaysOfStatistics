using System;

namespace Day_06
{
    internal class PoissonDistribution2
    {
        internal static void Execute( )
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */


            double xA = 0.88 + Math.Pow(0.88, 2); ;
            double dailyCostOfA = 160 + (40 * xA);

            double xB = 1.55 + Math.Pow(1.55, 2);
            double dailyCostOfB = 128 + (40 * xB);

            Console.WriteLine(Math.Round(dailyCostOfA, 3));
            Console.WriteLine(Math.Round(dailyCostOfB, 3));
            Console.ReadLine();
        }
    }
}
