using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando variables
            string make = "Mercedes-Benz";
            string model = "AMG";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output informacion formateada
            Console.WriteLine("Este es un carro {0} {1} {2}, con {3} millas y un costo de ${4}",
                year, make, model, miles, price);

            // TODO: String interpolation


            // TODO: inline expressions


        }
    }
}
