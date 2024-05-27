using System;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Please, write a palindrome word or phrase: ");
            string input = Console.ReadLine();

            // Para verificar si la entrada es nula o vacía
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("The entry cannot be empty. Please try again.");
                return;
            }

            // Con esto se eliminan puntuaciones y espacios en blanco
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!Char.IsPunctuation(c) && !Char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            string cleanedInput = sb.ToString().ToLower();
            string reversedInput = ReverseString(cleanedInput);

            // Se comprobará si es un palindromo
            bool isPalindrome = cleanedInput == reversedInput;
            Console.WriteLine($"¿Es palíndromo? {isPalindrome}");
        }
        catch (Exception ex)
        {
            // Excepciones
            Console.WriteLine($"Se produjo un error: {ex.Message}");
        }
    }

    static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
