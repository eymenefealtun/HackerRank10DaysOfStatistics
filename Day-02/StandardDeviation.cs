using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_02
{
    internal class StandardDeviation
    {
        public static void Execute()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

            stdDev(vals);
        }

        public static void stdDev(List<int> arr)
        {
            // Print your answers to 1 decimal place within this function

            decimal mean = arr.Sum() / arr.Count;

            decimal result = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                decimal a = (arr[i] - mean) * (arr[i] - mean);
                result += a;
            }

            result = (decimal)Math.Sqrt((double)result / (double)arr.Count);
            Console.WriteLine(String.Format("{0:0.0}", result));
            Console.ReadLine();
        }

    }
}