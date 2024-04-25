using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de strings para los ejercicios
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "This is a string";
            string[] strs = { "one", "two", "three", "four" };

            // TODO: Propiedad Length 
            // Retorna la longitud de la cadena de caracteres

            //Console.WriteLine($"The length of str1 is: {str1.Length}");


            // TODO: Acceder a characters individuales
            // Accede a un caracter en una posicion especifica

            //Console.WriteLine($"caracter posicion 14 {str1[14]}");



            // TODO: recorre un string como si fuese una secuencia
            // Itera sobre cada caracter de la cadena de caracteres
            //foreach (char c in str1)
            //{
            //    Console.WriteLine(c);
            //    if (c == 'o')
            //    {
            //        Console.WriteLine("Letra o encontrada");
            //        break;
            //    }
            //}



            // TODO: Comparacion entre strings
            // Comparacion entre orden de los caracteres

            //int result = string.Compare(str2, str1);
            //Console.WriteLine($"Comparacion entre str2 y str3: {result}");

            //if (result == 0)
            //{
            //    Console.WriteLine($"Las cadenas son iguales: {str2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Las cadenas son diferentes: {str1},{str2}");
            //}


            // TODO: Equals retorna un Boolean
            // Retorna un valor booleano que indica si dos cadenas son iguales

            //bool areEqual = str2.Equals(str1);
            //Console.WriteLine($"Return de metodo Equals: {areEqual}");

            //if (areEqual)
            //{
            //    Console.WriteLine($"Las cadenas son iguales: {str2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Las cadenas son diferentes: {str1},{str2}");
            //}


            // TODO: String index, search y replace
            // https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0

            Console.WriteLine($"Index of 'fox' in str1: {str1.IndexOf("fox")}");
            Console.WriteLine($"LastIndex of 'e' in str1: {str1.LastIndexOf("e")}");

            outstr = str1.Replace("quick", "slow");
            Console.WriteLine($"Replace 'quick' with 'slow': {outstr}");

            string value = "This is a short string.";
            char delimiter = 's';
            string[] substrings = value.Split(delimiter);
            foreach (var substring in substrings)
                Console.WriteLine(substring);
        }
    }
}
