

using System;
using System.Collections.Generic;
using System.Linq;

class Mostoccured
{

    static void Main(){

        int[] arr = { 4, 2, 4, 5, 2, 3, 4, 2, 4, 4 };
        var frequency = new Dictionary<int,int>();

        foreach(int num in arr){

            if (frequency.ContainsKey(num))

                frequency[num] ++;
            

            else

                frequency[num] --;
            
        }

        int maximum  =  frequency.OrderByDescending(x => x.Value).First().Key;
        int mostoccured = frequency[maximum];
        
        Console.WriteLine("The most occurred number is: " + maximum);
        Console.WriteLine("It appears " + mostoccured + " times.");


    }

    
}