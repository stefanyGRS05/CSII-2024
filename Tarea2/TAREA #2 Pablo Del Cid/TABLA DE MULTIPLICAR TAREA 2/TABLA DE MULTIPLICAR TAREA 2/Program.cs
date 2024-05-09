using System;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa un número del 1 al 10:");
            int numero = int.Parse(Console.ReadLine());

            // Validar que el número esté dentro del rango permitido
            if (numero >= 1 && numero <= 10)
            {
                Console.WriteLine($"Tabla de multiplicar del {numero}:");

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("El número ingresado está fuera del rango permitido.");
            }
        }
    }
}
