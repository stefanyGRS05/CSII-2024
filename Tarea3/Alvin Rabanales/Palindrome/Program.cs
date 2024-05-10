using System.Text;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una frase o palabra: ");
        string userInput = Console.ReadLine();
        userInput = new string(userInput.Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c)).ToArray());
        Console.WriteLine(EsPalindromo(userInput));
    }

    public static bool EsPalindromo(string input)
    {
        StringBuilder sb = new StringBuilder();
       
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        
        string revertido = sb.ToString();
        
        if (input == revertido)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

