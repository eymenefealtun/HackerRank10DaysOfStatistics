using System;

namespace Day_05
{
    internal class BinomialDistribution1
    {

        public static void Execute()
        {
            //                          Task
            //The ratio of boys to girls for babies born in Russia is 1.09 / 1.
            //If there is 1 child born per birth, what proportion of Russian
            //families with exactly 6 children will have at least 3 boys ?


            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] input = Console.ReadLine().Split(' ');

            double boy = Convert.ToDouble(input[0]);
            double girl = Convert.ToDouble(input[1]);

            float boyPercentage = (float)(boy / (boy + girl));

            int n = 6;

            //In this question we want at least 3 boy so we added Binomial of 3, 4, 5, and 6.
            double result = Binomial(3, n, boyPercentage) + Binomial(4, n, boyPercentage) + Binomial(5, n, boyPercentage) + Binomial(6, n, boyPercentage);

            Console.WriteLine(Math.Round(result, 3));
            Console.ReadLine();
        }

        static double Binomial(double x, double n, double p)
        {
            // x: The value of lowest desired value.(In this case, we want at least 3 boys. So x[] must be equal to --> {3, 4, 5, 6})
            // p: The value of probability of our case.
            // n: The value of trials. (In this case we know that the familiy has 6 child.)

            double f = Factorial(n) / (Factorial(n - x) * Factorial(x)); // --> nCr formula

            return (f * Math.Pow(p, x) * Math.Pow((1 - p), (n - x))); // --> nCr * p ** x * 1-p ** n-x ( 1-p means the probability of not)
             
            // Note: (2 ** 3 = 2 * 2 * 2 = 8)
        }

        static int Factorial(double n)
        {
            if (n < 2)
                return 1;
            return ((int)(Factorial(n - 1) * n));
        }
    }
}
