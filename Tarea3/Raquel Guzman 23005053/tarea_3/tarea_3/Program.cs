using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.WriteLine("\n\tTarea numero 3");
        Console.WriteLine("Ingrese una palabra:");
        string phrase = Console.ReadLine().ToLower();

        /*string builder*/ 
        StringBuilder sb = new StringBuilder();

        /**/
        foreach (char c in phrase)
        {
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                sb.Append(c);
            }
        }

        /**/
        string clearterm = sb.ToString();

        // 
        string palabraInvertida = InverseTerm(clearterm);

        if (clearterm.Equals(palabraInvertida))
        {
            Console.WriteLine("La palabra ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra ingresada no es un palíndromo.");
        }

        Console.Write("\n\tmuchas gracias por su atencion, Presione dos veces <<ENTER>> para finalizar . . . :')");
        Console.ReadKey();
    }

    /*--*/
    static string InverseTerm(string phrase)
    {
        /*--*/
        StringBuilder sb = new StringBuilder();
        for (int i = phrase.Length - 1; i >= 0; i--)
        {
            sb.Append(phrase[i]);
        }
        return sb.ToString();


    }

 
}






