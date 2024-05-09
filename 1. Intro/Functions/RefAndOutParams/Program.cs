using System;
using System.Diagnostics.CodeAnalysis;

namespace RefAndOutParams
{
    class Program
    {
        // TODO: El valor de los argumentos no puede ser modificado por la funcion
        // porque estos son una copia del valor original
        static void TestFunct(int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }


        // TODO: Argumentos pasados como reference pueden ser modificados
        // por la funcion y executados
        static void TestFunct2(ref int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }



        // TODO: El "out" keyword significa que el parametro regresa un valor
        // usado para suplir de data a la misma funcion
        static void TestFunct3(int arg1, int arg2, out int result1, out int result2)
        {
            result1 = arg1 + arg2;
            result2 = arg1 * arg2;
        }


        static void Main(string[] args)
        {
            int val1 = 8;
            int val2 = 20;

            // Function no modifican argumentos normalmente
            TestFunct(val1);
            Console.WriteLine($"{val1}");


            // TODO: Usando el "ref" keyword, argumentos pueden ser pasados por referencia
            // lo que permite a la funcion modificarlos
            //TestFunct2(ref val1);
            //Console.WriteLine($"{val1}");


            // TODO: El "out" keyword puede ser usado para indicar que un argumento
            // regresa un valor y no que es un input

            int res1, res2;
            TestFunct3(val1, val2, out res1, out res2);
            Console.WriteLine($"Suma:{res1}, Producto: {res2}");



        }
    }
}
