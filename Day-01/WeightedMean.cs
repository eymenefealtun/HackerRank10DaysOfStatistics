using System;
using System.Collections.Generic;
using System.Linq;

internal class WeightedMean
{

    /*
     * Complete the 'weightedMean' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY X
     *  2. INTEGER_ARRAY W
     */
    internal static void Execute()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

        List<int> weights = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(weightsTemp => Convert.ToInt32(weightsTemp)).ToList();

        WeightedMean.weightedMean(vals, weights, n);
    }

    internal static void weightedMean(List<int> X, List<int> W, int n)
    {
        Console.Clear();

        decimal xResult = 0;
        for (int i = 0; i < n; i++)
            xResult += W.ToArray()[i] * X.ToArray()[i];

        decimal result = Convert.ToDecimal(xResult / W.Sum());

        Console.WriteLine(String.Format("{0:0.0}", result));
        Console.ReadLine();

    }

}


