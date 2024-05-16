using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._3_Verificar_si_es_palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese una palabra o frase para verificar si es un palíndromo:");
            string input = Console.ReadLine();



            // Eliminar puntuaciones y espacios en blanco del input

            StringBuilder cleanInput = new StringBuilder();

            foreach (char c in input)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    cleanInput.Append(c);
                }
            }

            // Verificar si el input es un palíndromo

            bool esPalindromo = EsPalindromo(cleanInput.ToString());

            // Mostrar el resultado
            Console.WriteLine("¿Es un palíndromo? " + esPalindromo);
        }

        static bool EsPalindromo(string str)
        {
            // Usar StringBuilder para comparar más eficientemente

            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return str.Equals(reversed.ToString(), StringComparison.OrdinalIgnoreCase);
        }









    }
    }

