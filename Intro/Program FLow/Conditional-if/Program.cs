using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 59;

            // TODO: if-else 
            //if (theVal == 50)
            //{
            //    Console.WriteLine("theVal is 50");
            //}
            //else
            //{
            //    Console.WriteLine("theVal is not 50");
            //}

            // -----------------------
            // TODO: Usando el ternary operator (condition)?(if True):(if False)
            // Abreviar el siguiente if-else
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: metodo abreviado usando ?:
            Console.WriteLine(theVal < 500 ? "theVal is small" : "theVal is large");

        }
    }
}
