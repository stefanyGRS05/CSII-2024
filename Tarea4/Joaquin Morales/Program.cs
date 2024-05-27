using System;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string name;
            string lastName;
            decimal balanceInicial=0.0m;
            bool final = false;
            bool check = false;
            int opcion;


            //Pedir Valores
            Console.WriteLine("Creacion de nueva cuenta...");
            Console.WriteLine("Primer Nombre de la cuenta: ");
            name = Console.ReadLine();
            Console.WriteLine("Apellido de la cuenta: ");
            lastName = Console.ReadLine();
            do 
            {                
                Console.WriteLine("Balance Inicial para la cuenta: ");
                if (decimal.TryParse(Console.ReadLine(), out balanceInicial))
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor valido");
                }
            } while (!check);

            //Crear cuenta
            Cuenta cuenta1 = new Cuenta(name,lastName,balanceInicial);
            Console.WriteLine(cuenta1.ToString());
            
            do
            {
                Console.WriteLine("Presione 1 para depositar, 2 para retirar o 3 para salir: ");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Seleccione una opcion valida.");
                    throw;
                }
                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cantidad a depositar:");
                        cuenta1.Deposit(decimal.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Cantidad a retirar:");
                        cuenta1.Retiro(decimal.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Adios");
                        final = true;
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida.");
                        break;
                }
            }while(!final);
        }
    }
}