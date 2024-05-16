using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        bool inputValid = false;

        while (!inputValid)
        {
            Console.WriteLine("Enter some text:");
            string? input = Console.ReadLine();
            int number;

            try
            {
                if (input == "" || input == null)
                {
                    throw new Exception("Input Empty, please type something!");
                }

                if (input.Length <= 2)
                {
                    throw new Exception("Please type a word with a length of at least 3 characters");
                }

                if (int.TryParse(input, out number))
                {
                    throw new FormatException("Invalid format, letters only");
                }

                // finish program
                inputValid = true;

                string newInput = "";
                foreach (char c in input)
                {
                    if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                    {
                        newInput += c;
                    }
                }

                // Reverse input
                StringBuilder sb = new StringBuilder(newInput, 200);
                string inputReversed = new string(newInput.Reverse().ToArray());

                if (sb.ToString() == inputReversed)
                {
                    Console.WriteLine($"{true}, Si es Palindrome");
                }
                else
                {
                    Console.WriteLine($"{false}, No es Palindrome");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}