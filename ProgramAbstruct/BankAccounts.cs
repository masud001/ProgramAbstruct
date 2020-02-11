using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAbstruct
{
    
    class BankAccounts
    {
        protected int balance = 5000;

    }
    class WithdrawAmount : BankAccounts
    {
        protected int amount;
        public int Withdraw(int a)
        {
            amount = a;
            Console.WriteLine("widthdraw Amount is : "+ (balance -= amount));
            return balance;
        }
    }
    class DepositAmount : WithdrawAmount
    {
        
        public int Deposit(int d)
        {
            amount = d;
            Console.WriteLine("Deposit amount is: " + (balance += amount));
            return balance;
        }
    }
    class CurrentBalance : DepositAmount
    {
        public int Balance()
        {
            return balance;
        }
    }
}
