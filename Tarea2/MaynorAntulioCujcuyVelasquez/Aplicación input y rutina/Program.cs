using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, click and enter your name:\n");
        string name = Console.ReadLine();

        Console.WriteLine($"\nGood day, {name}! Next, enter a whole number in the range of 1 to 10:\n");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine($"\nHere is the multiplication table for number {number}:\n");
                for (int multiplier = 1; multiplier <= 10; multiplier++)
                {
                    int product = number * multiplier;
                    Console.WriteLine($"{number} x {multiplier} = {product}");
                }
            }
            else
            {
                Console.WriteLine("\nError: The number is outside the range of 1 to 10! \nClose to try again.");
            }
        }
        else
        {
            Console.WriteLine("\nError: You must enter a whole number! \nClose to try again.");
        }
    }
}
