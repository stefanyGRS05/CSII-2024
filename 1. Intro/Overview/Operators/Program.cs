using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables para utilizar con los operadores
            float x = 10, y = 5;
            string a = "abcd", b = "efgh";

            // TODO: Operadores basicos +, -, /, *
            //Console.WriteLine("----- Basic Math -----");
            //Console.WriteLine((x - y) / x);
            //Console.WriteLine(a + b);


            // // TODO: ++ / -- operadores abreviados
            // Console.WriteLine("----- Shorthand -----");
            //x++;
            //y--;
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            // // TODO: Operaciones que pueden ser abreviadas: a = a + b
            //a += b;
            //Console.WriteLine(a);

            //x += y;
            //Console.WriteLine(x);


            // TODO: Operadores Logicos && (and), || (or)
            // Console.WriteLine("----- Logic Operators -----");
            //Console.WriteLine(x > y && y >= 10);
            //Console.WriteLine(x > y || y >= 500);


            // TODO: Operadores con null
            string str = "string original";

            // TODO: el ?? operador
            //Console.WriteLine(str ?? "Unknown string");


            // TODO: el ??= operador asigna el lado izquiero con el derecho si su valor es null
            // funciona como reemplazo:
            //if (variable is null)
            //{
            //    variable = somevalue;
            //}

            str ??= "New string";
            Console.WriteLine(str);

        }
    }
}
