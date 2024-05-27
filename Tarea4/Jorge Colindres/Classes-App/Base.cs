using System;

namespace App
{
    public class Base
    {

        string _firstName;
        string _lastName;
        decimal _balance = 0.0m;

        public Base(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string Desc
        {
            get { return $"{_firstName} {_lastName}, your Current Balance is: {_balance}"; }
        }

        public decimal Deposit(decimal balance)
        {
            return _balance += balance;
        }

        public decimal Withdrawal(decimal amountToWithdraw)
        {
            return _balance -= amountToWithdraw;
        }
    }
}