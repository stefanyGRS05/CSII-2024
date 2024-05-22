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

            Base user = new Base("Pedro", "Méndez");

            while (!isValid)
            {
                Console.WriteLine("Please enter an amount to deposit:");
                string depositInput = Console.ReadLine();
                Console.WriteLine("Please enter a withdraw amount:");
                string withdrawInput = Console.ReadLine();

                try
                {
                    if (decimal.TryParse(depositInput, out depositValue) && decimal.TryParse(withdrawInput, out withdrawValue))
                    {
                        if (depositValue <= 0 || withdrawValue <= 0)
                        {
                            throw new FormatException("Balance and Withdraw values cannot be less than zero");
                        }

                        if (withdrawValue > depositValue)
                        {
                            throw new Exception("Withdrawal not possible, insufficient funds");
                        }

                        user.Deposit(depositValue);

                        user.Withdrawal(withdrawValue);

                        isValid = true;

                        Console.WriteLine($"You Deposited: {depositValue}");
                        Console.WriteLine($"Your Withdrew is: {withdrawValue}");
                        Console.WriteLine(user.Desc);
                    }
                    else
                    {
                        throw new FormatException("Error, Invalid Value");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}