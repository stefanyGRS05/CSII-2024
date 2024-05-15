using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples son valores agrupados introducido desde .NET 7
            (int a, int b) tup1 = (1, 2);
            var tup2 = ("texto", 10.5f);

            // TODO: los valores dentro del Tuple son modificables
            tup1.b = 20;
            tup2.Item1 = "nuevo texto";
            Console.WriteLine($"{tup1.a} {tup1.b}");
            Console.WriteLine($"{tup2.Item1} {tup2.Item2}");

            // TODO: Functions trabajan con tuples
            (int, int) result = TestFunct3(10, 20);
            Console.WriteLine($"Suma:{result.Item1}, Producto:{result.Item2}");

        }

        // TODO: Functions pueden regresar multiples valores usando tuples
        static (int, int) TestFunct3( int a, int b)
        {
            return (a+b, a*b);
        }


    }
}
