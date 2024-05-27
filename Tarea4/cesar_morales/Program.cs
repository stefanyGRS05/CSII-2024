using System;
using System.Text;

namespace Bank_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese primer nombre: ");
            string firstName = Console.ReadLine();

            Console.Write("Ingrese primer apellido: ");
            string lastName = Console.ReadLine();

            Account account = new Account(firstName, lastName);

            Console.Write("Ingrese la cantidad a depositar: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal cantidadDeposito))
            {
                account.Deposito(cantidadDeposito);

                Console.Write("Ingrese la cantidad a retirar: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal cantidadRetiro))
                {
                    account.Retiro(cantidadRetiro);
                }
                else
                {
                    Console.WriteLine("Cantidad no válida para el retiro.");
                }

            }
            else
            {
                Console.WriteLine("Cantidad no válida para el depósito.");
            }

        }
    }
}