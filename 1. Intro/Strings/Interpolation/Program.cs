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
            float miles = 8450.27f;
            decimal price = 60275.0m;

            // TODO: Output informacion formateada
            Console.WriteLine("Este es un carro {0} {1} {2}, con {3} millas y un costo de ${4}",
                year, make, model, miles, price);

            // TODO: String interpolation
            Console.WriteLine($"Este es un carro {year} {make} {model}, con {miles} millas y un costo de ${price}");


            // TODO: inline expressions
            Console.WriteLine($"Este es un carro {year} {make} {{{model}}}, con {{{miles * 1.6:F2}}} kilometros y un costo de ${price}");

        }
    }
}
