using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4! = 4*3*2*1
            // 6! = 6*5*4*3*2*1

            //declare the necessary variables
            int i, fact = 1, number;

            //print the message to show user
            Console.Write("Please Enter any Number: ");

            //catch the input from user
            number = int.Parse(Console.ReadLine());

            //continue the program until i is equal or less than number
            for(i=1; i<= number; i++)
            {
                fact = fact * i;

            }
            //print the factorial number
            Console.Write("Factorial of " + number + " is " + fact);

        }
    }
}
