using System;

namespace BancoApp
{
    public class CuentaBancaria
    {
        public string PrimerNombre { get; }
        public string Apellido { get; }
        public decimal Balance { get; protected set; }

        public CuentaBancaria(string primerNombre, string apellido)
        {
            PrimerNombre = primerNombre;
            Apellido = apellido;
            Balance = 1900.0m;
        }

        // Método para depositar dinero
        public virtual void Deposit(decimal cantidad)
        {
            Balance += cantidad;
        }

        // Método para retirar dinero
        public virtual void Retiro(decimal cantidad)
        {
            if (Balance >= cantidad)
                Balance -= cantidad;
            else
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
        }

        // Método para obtener el balance actual
        public decimal ObtenerBalance()
        {
            return Balance;
        }
    }

    // Clase para cuentas de ahorro
    public class CuentaAhorro : CuentaBancaria
    {
        public CuentaAhorro(string primerNombre, string apellido) : base(primerNombre, apellido)
        {
        }
    }

    // Clase para cuentas monetarias
    public class CuentaMonetaria : CuentaBancaria
    {
        public CuentaMonetaria(string primerNombre, string apellido) : base(primerNombre, apellido)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al Banco GaliBank!");

            // Estos Console.ReadLine le permiten al usuario ingresar su nombre y apellido para crear una cuenta
            Console.Write("Ingrese su primer nombre: ");
            string primerNombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            // Y con estos se le permite al usuario seleccionar el tipo de cuenta que desea crear
            Console.WriteLine("Seleccione el tipo de cuenta:");
            Console.WriteLine("1. Cuenta de Ahorro");
            Console.WriteLine("2. Cuenta Monetaria");
            int opcion = int.Parse(Console.ReadLine());

            CuentaBancaria cuenta;
            if (opcion == 1)
                cuenta = new CuentaAhorro(primerNombre, apellido);
            else
                cuenta = new CuentaMonetaria(primerNombre, apellido);

            // Menú con las opciones con bucle while y un switch para seleccionar la opción deseada y case para realizar la acción
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar balance");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int menuOpcion = int.Parse(Console.ReadLine());

                switch (menuOpcion)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad a depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        cuenta.Deposit(deposito);
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad a retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retiro(retiro);
                        break;
                    case 3:
                        Console.WriteLine($"Balance actual: {cuenta.ObtenerBalance():C}");
                        break;
                    case 4:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }

            Console.WriteLine("¡Gracias por usar nuestros servicios bancarios!");
        }
    }
}