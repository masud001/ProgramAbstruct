using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAbstruct
{
    class CurrentBalance
    {
        protected int balance = 100;
        public int MainBalance()
        {
            Console.WriteLine("your Main Balance is : " + balance);
            return balance;
        }
    }
    class WithdrawAmount : CurrentBalance
    {
        protected int amount;
        public bool Withdraw(int a)
        {
            amount = a;
            Console.WriteLine("withdraw Amount is : " + amount);
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("widthdraw Amount is less than main balance: " + (balance - amount));
            }

            return false;
        }
    }
    class DepositAmount : WithdrawAmount
    {
        public int Deposit(int d)
        {
            amount = d;
            Console.WriteLine("Deposit amount is : " + amount);

            return balance = (balance += amount);
        }
    };

    class BankAccounts : DepositAmount
    {
        public int Balance()
        {
            return balance;
        }
    }
}

