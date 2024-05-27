using System;

class Program
{
    static void Main(string[] args)
    {
		int opcion=0;
		bool check = false;
		do
		{ 
			Console.WriteLine("Ingrese un numero del 1 al 10:");
            try
			{
				opcion = int.Parse(Console.ReadLine());
			}
			catch (Exception e)
			{
                
            }
            
			if (opcion > 0 && opcion < 11)
            {
                check = true;
            }
			else
			{
                Console.WriteLine("Valor no aceptado");
            }

        } while (!check);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {opcion} = {i*opcion}");
        }
    }
}