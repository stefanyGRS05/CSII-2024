using System;
using System.Globalization; // Necesario para el NumberStyles

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            // Parse es la funcion que trata de convertir un string en numero
            // pueden aparecer excepciones, necesitamos manejarlas
            int targetNum = 0;
            try
            {
                // TODO: Intentar con data type integer
                targetNum = int.Parse(numStr1);

                Console.WriteLine($"{targetNum}");


                // TODO: Usar Parse con float number
                targetNum = int.Parse(numStr2, NumberStyles.Float);

                Console.WriteLine(targetNum);


                // TODO: Usar Parse con thousands marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);


                // TODO: Usar Parse con thousands marker y decimal
                targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
                Console.WriteLine(targetNum);


                // TODO: Usar con bool
                Console.WriteLine($"{bool.Parse("true")}"); // True


                // TODO: Usar floating point numbers
                Console.WriteLine($"{float.Parse("1.235"):F2}");
            }
            catch
            {
                Console.WriteLine("Conversion fallida ");
            }

            // TODO: El TryParse es similar pero maneja exceptions por nosotros
            bool succeeded = false;
            succeeded = int.TryParse(numStr2, out targetNum);

            if (succeeded)
            {
                Console.WriteLine($"{targetNum}");
            }
            else
            {
                Console.WriteLine("Conversion fallida");
            }
        }
    }
}
