using System;

/// comment shortcut : ctrl + k + c

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de variables y como se declaran
            int i = 10;
            float f = 2.999f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Tipo de variable string, a collection of characters
            string str = "a string";

            // // Declaracion implicita de variable
            var x = 10.5;
            var z = "Hello!";

            // Declaracion de un array de vals
            int[] vals = new int[5];
            string[] strs = { "uno", "dos", "tres" };

            // TODO: Print todos los vals utilizando Formating String

            //Console.WriteLine("i = {0}, float = {1}, string ={2}",i,f,str);

            //TODO: Print utilizando Interpolation

            //Console.WriteLine($"f = {f}, integer={i}, string={str}");


            // "null" significa "no value"
            //object obj = null;
            //Console.WriteLine(obj);

            // Implicit conversion between types
            long bignum;
            bignum = i;

            Console.WriteLine("long bignum {0}", bignum);

            // // Explicit conversions
            float i_to_f = (float)i;
            Console.WriteLine("float {0}", i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine("conversion de float a int: {0}", f_to_i);

        }
    }
}
