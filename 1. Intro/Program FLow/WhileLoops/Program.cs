using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "exit";

            // TODO: while loop se ejecuta mientras la condicion sea true
            //Console.WriteLine("Basic while() loop:");

            //while (inputStr != "exit")
            //{
            //    Console.Write("Entren una cadena de texto (o 'exit' para salir): ");
            //    inputStr = Console.ReadLine();
            //}


            //Console.WriteLine();

            // TODO: do-while loop siempre se ejecuta por lo menos una vez
            //Console.WriteLine("do-while() loop:");

            do
            {
                Console.Write("Entren una cadena de texto (o 'exit' para salir): ");
                inputStr = Console.ReadLine();
            }
            while (inputStr != "exit");


            //Console.WriteLine();
        }
    }
}
