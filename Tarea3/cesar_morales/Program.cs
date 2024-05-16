using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static bool Palindrome(string input)
        {
            input = input.ToLower();
            char[] cArray = input.ToCharArray();
            Array.Reverse(cArray);
            string reverse = new string(cArray);
            return input == reverse ? true : false;
        }

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            String userText = "";

            Console.Write("Ingrese una frase o palabra: ");

            userText = Console.ReadLine()!;



            foreach (char ch in userText)
            {
                if (!char.IsWhiteSpace(ch) && !char.IsPunctuation(ch)){
                    sb.Append(ch);
                }
            }

            //sb.Append(userText);
            //sb.Replace(" ", "");
            //sb.Replace(".", "");
            if(sb.ToString() != "")
            {
                Boolean palindrome = Palindrome(sb.ToString());
                Console.WriteLine($"La palabra es Palindrome: {palindrome}");
            }
            else{
                Console.WriteLine("ERROR: DEBE INGRESAR UNA PALABRA O FRASE.");
            }

        }
    }
}

