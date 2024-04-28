using System;
class Program

{
   static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de 1 a 10: ");
        string entrada = Console.ReadLine();

        try
        {
            int numeroUsuario = Convert.ToInt32(entrada);
            Console.WriteLine($"El número ingresado es: {numeroUsuario}");
            if (numeroUsuario < 1 || numeroUsuario > 10)
            {
                Console.WriteLine("El número ingresado no está en el rango de 1 a 10.");
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroUsuario} x {i} = {numeroUsuario * i}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("La entrada no es un número entero válido.");
        }




    }
}