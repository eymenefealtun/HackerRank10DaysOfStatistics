using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        double inCorrectSizePercentage =0.12 ;
        int numberOfPistons = 10;

        double resultForQ1 = Binomial(0, numberOfPistons, inCorrectSizePercentage) + Binomial(1, numberOfPistons, inCorrectSizePercentage) + Binomial(2, numberOfPistons, inCorrectSizePercentage);

        double resultForQ2 = 0;
        for (int i = 2; i <= 10; i++)
            resultForQ2 += Binomial(i, numberOfPistons, inCorrectSizePercentage);


        Console.WriteLine(Math.Round(resultForQ1, 3));
        Console.WriteLine(Math.Round(resultForQ2, 3));
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