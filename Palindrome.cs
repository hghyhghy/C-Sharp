

using System;

class Palindrome
{

    static void Main(){

        Console.Write("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if(Check(num)){

            Console.WriteLine(num + "is a palindrome");
        }

        else
        {
            Console.WriteLine(num+"Is not a palindrome");
        }
    }


    static bool Check(int number){

        int original =  number;
        int reversed = 0;

        while (number > 0)
        {
            int digit  =  number%10;
            reversed =  reversed*10 + digit;
            number /= 10;


        }

        return original ==  reversed;
    }

}