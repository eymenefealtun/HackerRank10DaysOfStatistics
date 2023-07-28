using System;
using System.Collections.Generic;
using System.Linq;

internal class MeanMedianMode
{

    internal static void Execute()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string[] array = Console.ReadLine().Split(' ');
        int[] givenArray = new int[n];

        for (int i = 0; i < n; i++)
            givenArray[i] = Convert.ToInt32(array[i]);

        decimal mean = 0;
        for (int i = 0; i < n; i++)
            mean += givenArray[i];

        mean = mean / n;

        SortArray(givenArray);

        decimal median = 0;
        int middleIndex = n / 2 - 1;
        median = Convert.ToDecimal(((decimal)givenArray[middleIndex] + (decimal)givenArray[middleIndex + 1]) / 2);

        int mode = GetMostFrequentNumber(givenArray);


        Console.Clear();

        Console.WriteLine(mean);
        Console.WriteLine(median);
        Console.WriteLine(mode);

        Console.ReadLine();
    }


    internal static void SortArray(int[] array)
    {

        for (int i = 0; i < array.Length - 1; i++)
        {
            int minimumIndex = i;

            for (int j = i + 1; j < array.Length; j++)
                if (array[minimumIndex] > array[j])
                    minimumIndex = j;


            int currentNumber = array[i];

            array[i] = array[minimumIndex];
            array[minimumIndex] = currentNumber;

        }
    }


    internal static int GetMostFrequentNumber(int[] intArray)
    {

        List<int> listOfInts = new List<int>();

        int[] indexes = new int[intArray.Length];

        for (int i = 0; i < intArray.Length; i++)
        {
            int currentNumber = intArray[i];
            listOfInts.Add(currentNumber);

            // If the number found before, it finds the index of number found inside the indexes array and increase by 1.
            if (listOfInts.Contains(currentNumber))
                indexes[listOfInts.FindIndex(x => x == currentNumber)]++;
        }

        return intArray[Array.FindIndex(indexes, x => x == indexes.Max())];
    }

}