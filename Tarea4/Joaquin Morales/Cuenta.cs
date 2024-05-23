using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Cuenta
    {
        //Variables
        private string name;
        private string lastName;
        private decimal balance = 0.0m;

        //Propiedades
        public decimal Balance{ 
            get { return balance; }
            set { balance = value; }
        }

        //Constructor
        public Cuenta(string _name, string _lastname, decimal _balance) 
        { 
            lastName = _lastname;
            balance = _balance;
            name = _name;
        }

        //Funciones
        public virtual void Deposit (decimal deposito)
        {
            Balance += deposito;
            Console.WriteLine($"Balance actual: ${balance}");
        }
        public virtual void Retiro(decimal retiro)
        {
            if (retiro < balance)
            {
                Balance -= retiro;
                Console.WriteLine($"Balance actual: ${balance}");
            }
            else
            {
                Console.WriteLine("Su balance es insuficiente para realizar la transaccion.");
                Console.WriteLine($"Balance actual: ${balance}");
            }
            
        }
        public override string ToString()
        {
            return $"La cuenta de {name} {lastName} was created with a balance of ${Balance}";
        }

    }
}
