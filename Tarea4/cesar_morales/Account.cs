using System;
using System.Text;

namespace Bank_OOP
{

    public class Account
    {
        private string _firstName;
        private string _lastName;
        private decimal _balance;

        public Account(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _balance = 0;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }


        public decimal Balance
        {
            get => _balance;
        }

        public void Deposito(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            _balance += amount;
            Console.WriteLine($"Depósito de {amount:C} realizado. Balance actual: {_balance:C}");
        }

        public void Retiro(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Ingresar una cantidad a retirar mayor a 0.");
            }

            if (amount > _balance)
            {
                throw new Exception("Fondos insuficientes para realizar el retiro.");
            }

            _balance -= amount;
            Console.WriteLine($"Retiro de {amount:C} realizado. Balance actual: {_balance:C}");
        }



    }

}