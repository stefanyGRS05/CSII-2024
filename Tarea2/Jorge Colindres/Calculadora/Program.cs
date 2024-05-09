using System;

class Program
{
    static void Main(string[] args)
    {
        int[] mutiplyTable = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        bool isValidInput = false;

        while (!isValidInput)
        {
            try
            {
                int valueToMultiply = 0;


                Console.WriteLine("Please enter a number between 1 to 10:");
                string? userInput = Console.ReadLine();

                if (int.TryParse(userInput, out valueToMultiply))
                {
                    valueToMultiply = int.Parse(userInput);
                }
                else
                {
                    throw new FormatException("Format incorrect, please enter a number");
                }

                if (valueToMultiply <= 0 || valueToMultiply > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }

                isValidInput = true;

                Console.WriteLine("Results: ");
                foreach (int value in mutiplyTable)
                {
                    Console.WriteLine(value + " x " + valueToMultiply + " = " + (value * valueToMultiply));
                }


            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Value out of range, Please enter a valid number");
            }
        }

    }
}