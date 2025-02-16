
using System;

class Largestnum
{

    static void Main()
    {

        int[] arr={12,1,34,5,19};

        int max= arr[0];

        for (int i=1 ; i < arr.Length ; i++){

            if (arr[i] > max){

                max  = arr[i];
            }
        }

        Console.WriteLine("The largest number in the given array is: " + max);
    }
}