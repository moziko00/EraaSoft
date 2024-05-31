using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_D04_Part02
{
    public class Account
    {
        private decimal _balance;
        private string _name;

        public Account(string name, decimal balane)
        {
            _balance = balane;
            _name = name;
        }

        public bool Deposite(decimal amountToDeposite)
        {
            if (amountToDeposite > 0)
            {
                _balance += amountToDeposite;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal amountToDraw)
        {
            if (_balance > 0)
            {
                _balance -= amountToDraw;
                return true;
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine($"The Name is {_name}and The Blance is {_balance}");
        }


    }
}
