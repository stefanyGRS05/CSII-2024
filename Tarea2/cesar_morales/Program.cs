using System;

namespace HelloWorld
{
    class Program
    {
        static string preguntaContinuar()
        {
            string continuar = "";
            Console.Write("\n\t> Desea intentar nuevamente (N/s): ");
            continuar = Console.ReadLine()!;
            continuar = continuar.ToLower() != "s" ? continuar.ToLower() != "n" ? "n" : continuar.ToLower() : continuar.ToLower();
            return continuar;
        }
        static void Main(string[] args)
        {
            string continuar = "s";
            do
            {
                try
                {
                    int number = 0;

                    Console.WriteLine("\nPROGRAMA TABLA DE MULTIPLICAR");
                    Console.Write("Ingresar un número entre 1 y 10: ");
                    number = Convert.ToInt32(Console.ReadLine());


                    if (number > 0 || number < 11)
                    {
                        Console.WriteLine("");
                        for (int i = 1; i < 11; i++)
                        {
                            Console.WriteLine("{0,2} x {1} = {2,3}", i, number, i * number);
                        }
                        continuar = preguntaContinuar();
                    }
                    else
                    {
                        throw new Exception("Numeros fuera de rango");
                    }
                }
                catch
                {
                    Console.WriteLine("\nPara que el programa funcione es necesario que el valor ingresado sea un número entre 1 y 10.");
                    continuar = preguntaContinuar();
                    //Console.Clear();
                }
            } while (continuar.ToLower() == "s");

        }
    }
}