using System.Collections.Generic;
using System.Linq;
using System;

internal class Quartiles
{

    /*
     * Complete the 'quartiles' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> quartiles(List<int> arrr)
    {

        var arr = Quartiles.SortArray(arrr.ToArray()).ToList();
        List<int> result = new List<int>();
        int arrayLength = arr.Count;
        int middleIndex = arrayLength / 2;
        if (arrayLength % 2 == 0)
        {
            int lefMiddleIndex = (arrayLength - middleIndex) / 2 - 1;
            int rightMiddleIndex = middleIndex + ((arrayLength - middleIndex) / 2) - 1;


            if (lefMiddleIndex % 2 != 0)
                result.Add((arr[lefMiddleIndex + 1]));
            else
                result.Add((arr[lefMiddleIndex] + arr[lefMiddleIndex + 1]) / 2);

            result.Add((arr[middleIndex - 1] + arr[middleIndex]) / 2);

            if (middleIndex % 2 != 0)
                result.Add(arr[rightMiddleIndex] + 1);
            else
                result.Add((arr[rightMiddleIndex] + arr[rightMiddleIndex + 1]) / 2);
        }
        else
        {

            int lefMiddleIndex = (arrayLength - middleIndex) / 2 - 1;
            int rightMiddleIndex = (middleIndex / 2) + middleIndex;
            result.Add((arr[lefMiddleIndex] + arr[lefMiddleIndex + 1]) / 2);
            result.Add(arr[middleIndex]);
            result.Add((arr[rightMiddleIndex] + arr[rightMiddleIndex + 1]) / 2);
        }
        return result;
    }



    public static void Execute()
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> data = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();

        List<int> res = quartiles(data);

        Console.WriteLine(String.Join("\n", res));

        Console.ReadLine();
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

}