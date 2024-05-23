
using System;

namespace TransaccionesBancarias
{
    public class CuentaBancaria
    {
        // Propiedades para el Primer Nombre, Apellido y Balance
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        private decimal balance;

        // Propiedad Balance con getter y setter
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Constructor que acepta primer nombre y apellido, inicializa el balance en 0.0m
        public CuentaBancaria(string primerNombre, string apellido)
        {
            PrimerNombre = primerNombre;
            Apellido = apellido;
            Balance = 0.0m;
        }

        // Método para depositar dinero en la cuenta
        public void Depositar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad a depositar debe ser positiva.");
            }
            Balance += cantidad;
            Console.WriteLine($"Depósito exitoso. Nuevo balance: {Balance:C}");
        }

        // Método para retirar dinero de la cuenta
        public void Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad a retirar debe ser positiva.");
            }
            if (cantidad > Balance)
            {
                throw new InvalidOperationException("Fondos insuficientes para esta retirada.");
            }
            Balance -= cantidad;
            Console.WriteLine($"Retiro exitoso. Nuevo balance: {Balance:C}");
        }

        // Método para obtener el balance actual (para propósitos de demostración)
        public decimal ObtenerBalanceActual()
        {
            return Balance;
        }
    }
}

