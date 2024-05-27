using System;

namespace BankTransactions
{
    public class Account
    {
        // Propiedades
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private decimal balance;

        // Propiedad de acceso al balance con lectura y escritura
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Constructor que acepta el primer nombre y el apellido del dueño de la cuenta
        public Account(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            balance = 0.0m; // Balance inicial por defecto
        }

        // Método para depositar dinero
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("El monto a depositar debe ser mayor a cero.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Depósito de {amount:C} realizado. Balance actual: {balance:C}");
        }

        // Método para retirar dinero
        public void Retiro(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("El monto a retirar debe ser mayor a cero.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Retiro de {amount:C} realizado. Balance actual: {balance:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario su nombre y apellido
            Console.Write("Ingrese su primer nombre: ");
            string firstName = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string lastName = Console.ReadLine();

            // Crear una cuenta para el usuario
            Account account = new Account(firstName, lastName);

            // Solicitar al usuario la cantidad a depositar
            Console.Write("Ingrese la cantidad a depositar: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
            {
                account.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Cantidad no válida para el depósito.");
            }

            // Solicitar al usuario la cantidad a retirar
            Console.Write("Ingrese la cantidad a retirar: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
            {
                account.Retiro(withdrawAmount);
            }
            else
            {
                Console.WriteLine("Cantidad no válida para el retiro.");
            }

            // Mostrar el balance final
            Console.WriteLine($"Balance final: {account.Balance:C}");
        }
    }
}

