using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a non-negative integer to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long result = Factorial(number);
            Console.WriteLine($"The factorial of {number} is: {result}");
        }
    }
}