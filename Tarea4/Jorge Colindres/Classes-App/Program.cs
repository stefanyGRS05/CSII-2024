using System;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal depositValue = 0;
            decimal withdrawValue = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Please enter an amount to deposit:");
                string depositInput = Console.ReadLine();
                Console.WriteLine("Please enter a withdraw amount:");
                string withdrawInput = Console.ReadLine();

                if (decimal.TryParse(depositInput, out depositValue) && decimal.TryParse(withdrawInput, out withdrawValue))
                {
                    isValid = true;
                    Base user = new Base("Jorge", "Colindres", depositValue);
                    decimal withdraw = user.Withdrawal(withdrawValue);

                    Console.WriteLine(user.Desc);
                    Console.WriteLine($"Your Withdraw is: {withdraw}");
                    Console.WriteLine($"Now, Your Current Balance is: {user.Balance - withdraw}");
                }
                else
                {
                    Console.WriteLine("Error, Invalid Value");
                }
            }
        }
    }
}