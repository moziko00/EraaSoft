using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_D01
{
    public class Account
    {
        private decimal _balance;
        private string _name;

        // video 4.28

        public Account(decimal balance, string name)
        {
            _balance = balance;
            _name = name;
        }

        public void Deposite (decimal amountToAdd)
        {
            _balance= _balance + amountToAdd;

        }

        public void Withdraw (decimal amountToAdd)
        {
            _balance= _balance - amountToAdd;
        }

        public string Name
        { 
            get { return _name; }
        }

        public void Print()
        {
            Console.WriteLine($"The Name is {_name}and The Blance is {_balance}");
        }
    }
}
