namespace TAREA2_GALILEO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un número del 1 al 10:");
            int numero = int.Parse(Console.ReadLine());

            // Validar que el número esté entre 1 y 10
            if (numero < 1 || numero > 10)
            {
                Console.WriteLine("Error: El número debe estar entre 1 y 10.");
                return;
            }

            // Generar y mostrar la tabla de multiplicar
            Console.WriteLine("\nTabla de multiplicar del {0}:", numero);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, numero, i * numero);
            }
        }
    }
}
    
