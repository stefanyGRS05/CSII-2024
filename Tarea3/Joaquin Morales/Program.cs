using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        bool check = false;
        string str = "";
        StringBuilder sb = new StringBuilder();

        do
        {
            Console.WriteLine("Ingrese la palabra o frase que desea verificar:");
            str = Console.ReadLine();
            if (str.Length > 1)
            {                
                check = true;
            }
            else
            {
                str = "";
                Console.WriteLine("Ingrese una palabra o frase mayor a 1 caracter");
            }
        } while (!check);

        foreach (char c in str) 
        {
            if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) 
            { 
                sb.Append(c);
            }
        }

        //Reverse
        char[] stringArray = sb.ToString().ToLower().ToCharArray();
        Array.Reverse(stringArray);
        string reversedStr = new string(stringArray);

        if (sb.ToString().ToLower() ==  reversedStr)
        {
            Console.WriteLine("True");
        }
        else { Console.WriteLine("False"); }

        
    }
}