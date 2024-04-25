using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 0;
            int result;

            // TODO: try-catch expressions para capturar errores

            try
            {
                if (x > 1000)
                {
                    throw new ArgumentOutOfRangeException("X is too big");
                }
                result = x / y;
                Console.WriteLine("Result: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            { 
                Console.WriteLine($"X is out of range");
            }
            finally
            {
                Console.WriteLine("Finally block se ejecutara siempre");
            }

            

        }
    }
}
