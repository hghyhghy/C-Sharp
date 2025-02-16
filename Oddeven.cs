
using System;

class Oddeven
{

    static void Main(){

        Console.Write("Enter a number");
        int num =  Convert.ToInt32(Console.ReadLine());

        if (num %2 == 0){
            
            System.Console.WriteLine(num + " Is an even number");
        }
        else{
            
            System.Console.WriteLine(num + " is  an odd number");
        }
    }
}