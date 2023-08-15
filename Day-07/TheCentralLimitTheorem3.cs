using System;

internal class TheCentralLimitTheorem3
{
    internal static void Execute()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        double mean = 500 * 100;
        double standardDeviation = 80 * Math.Sqrt(100);
        double z = 1.96; // = standard score = number of standard deviations by which the value of a raw score is above or below the mean value of what is being observed or measured.

        double A = (mean - z * standardDeviation) / 100;
        double B = (mean + z * standardDeviation) / 100;


        Console.WriteLine(Math.Round(A, 2));
        Console.WriteLine(Math.Round(B, 2));
        Console.ReadLine();
    }


}
