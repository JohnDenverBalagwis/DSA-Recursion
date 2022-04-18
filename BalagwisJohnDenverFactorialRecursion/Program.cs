//JOhn Denver Balagwis
//BSI/T- 2F
//USing any programming Language create a program that print factorial number using recursion.

using System;

namespace BalagwisJohnDenverFactorialRecursion
{
    internal static class Program
    {
        //This part is the recursive  method
        //This will find the factorial
        //Here, we create a Factorial method with one parameter, which is the number for which we want to find the factorial.
        //Inside the function,we will have a condition that will keep track of when to end the recursion.
        private static int Factorial(int n)
        {
            //Here if the number is less than zero it will return -1 because n must be greater than or equal to 0.
            if (n < 0)
            {
                return -1;
            }
            // Here is the condition that if number is 0 it will return  and simply terminate the condition
            if (n == 0)
            {
                return 1;
            }
            //Here the recursive method call itself to calculate and return the factorial of the number.
            return n * Factorial(n - 1);
        }

        private static void Main(string[] args)
        {
            //Here we use the Convert.ToInt32 function to convert the user input into an integer.
            Console.Write("Enter any number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int fact = Factorial(value);
            //Print the factorial of the number
            Console.WriteLine($"\nFactorial of a number is: {fact}");
            Console.ReadLine();
        }
    }
}