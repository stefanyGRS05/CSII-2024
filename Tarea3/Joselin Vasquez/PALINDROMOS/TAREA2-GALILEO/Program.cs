using System.Text;

namespace TAREA2_GALILEO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra o frase:");
            string input = Console.ReadLine();

            // Eliminar puntuaciones y convertir a minúsculas
            StringBuilder normalizedInput = new StringBuilder();
            foreach (char e in input)
            {
                if (!char.IsPunctuation(e) && !char.IsWhiteSpace(e))
                {
                    normalizedInput.Append(char.ToLower(e));
                }
            }

            // Comprobar si es un palíndromo
            bool isPalindrome = IsPalindrome(normalizedInput.ToString());

            Console.WriteLine("Es un palíndromo: " + isPalindrome);
        }

        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}   
