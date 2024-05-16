using System;
using System.Text;

namespace AplicacionPalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa una palabra o frase: ");
            string input = Console.ReadLine();

            // Eliminación de espacios y signos de puntuación, y conversión total a minúsculas
            string cleanedInput = CleanString(input);

            // Creación de un StringBuilder para almacenar la versión invertida de la cadena
            StringBuilder reversed = new StringBuilder(cleanedInput.Length);
            for (int i = cleanedInput.Length - 1; i >= 0; i--)
            {
                reversed.Append(cleanedInput[i]);
            }

            // Comparación de la cadena original con la cadena invertida
            bool isPalindrome = cleanedInput.Equals(reversed.ToString());

            Console.WriteLine($"\n¿Es un palíndromo? {isPalindrome}");

            Console.ReadKey();
        }

        static string CleanString(string input)
        {
            // Eliminación de espacios y signos de puntuación, y conversión total a minúsculas
            StringBuilder cleaned = new StringBuilder(input.Length);
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    cleaned.Append(char.ToLower(c));
                }
            }
            return cleaned.ToString();
        }
    }
}
