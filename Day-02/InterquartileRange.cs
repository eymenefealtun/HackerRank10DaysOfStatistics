using System;
using System.Collections.Generic;
using System.Linq;

internal class InterquartileRange
{
    public static void Execute()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> val = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valTemp => Convert.ToInt32(valTemp)).ToList();

        List<int> freq = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(freqTemp => Convert.ToInt32(freqTemp)).ToList();

        interQuartile(val, freq);
    }


    public static int[] SortArray(in int[] givenArray)
    {

        for (int i = 0; i < givenArray.Length - 1; i++)
        {
            int minimumIndex = i;

            for (int j = i + 1; j < givenArray.Length; j++)
                if (givenArray[minimumIndex] > givenArray[j])
                    minimumIndex = j;


            int currentNumber = givenArray[i];

            givenArray[i] = givenArray[minimumIndex];
            givenArray[minimumIndex] = currentNumber;

        }

        return givenArray;

    }
    public static void interQuartile(List<int> values, List<int> freqs)
    {
        // Print your answer to 1 decimal place within this function
        List<int> resultArray = new List<int>();

        for (int i = 0; i < freqs.Count; i++)
            for (int j = 0; j < freqs[i]; j++)
                resultArray.Add(values[i]);

        resultArray = InterquartileRange.SortArray(resultArray.ToArray()).ToList();

        int arrayLength = resultArray.Count;
        int middleIndex = resultArray.Count / 2;

        decimal q1 = 0;
        decimal q3 = 0;
        if (resultArray.Count % 2 == 0)
        {

            int lefMiddleIndex = (arrayLength - middleIndex) / 2 - 1;
            int rightMiddleIndex = middleIndex + ((arrayLength - middleIndex) / 2) - 1;

            if (middleIndex % 2 != 0)
            {
                q1 = resultArray[lefMiddleIndex + 1];
                q3 = resultArray[rightMiddleIndex + 1];


            }
            else
            {
                q1 = (decimal)((decimal)resultArray[lefMiddleIndex] + (decimal)resultArray[lefMiddleIndex + 1]) / 2;
                q3 = (decimal)((decimal)resultArray[rightMiddleIndex] + (decimal)resultArray[rightMiddleIndex + 1]) / 2;
            }

        }
        else
        {
            int lefMiddleIndex = (arrayLength - middleIndex) / 2 - 1;
            int rightMiddleIndex = (middleIndex / 2) + middleIndex;


            if (lefMiddleIndex % 2 == 0)
            {
                q1 = resultArray[lefMiddleIndex + 1];
                q3 = (resultArray[rightMiddleIndex] + resultArray[rightMiddleIndex + 1]) / 2;
            }

            else
            {
                q1 = (resultArray[lefMiddleIndex] + resultArray[lefMiddleIndex + 1]) / 2;

                q3 = resultArray[rightMiddleIndex + 1];
            }
        }


        decimal result = (decimal)q3 - (decimal)q1;
        Console.WriteLine(String.Format("{0:0.0}", result));

        Console.ReadLine();

    }

}