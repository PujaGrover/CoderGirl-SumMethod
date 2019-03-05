using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter an integer: ");
            int inputValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of all integer numbers up to and including given value is:" + Sum(inputValue));
            Console.ReadLine();
        }
        public static int Sum(int value)
        {
            int n = value;
            return n * (n + 1) / 2;
        }

        // TODO: Create a method that returns the sum of all integer numbers up to and including given value. 
        // Use the equation (n * (n + 1)) / 2.
    }
}
