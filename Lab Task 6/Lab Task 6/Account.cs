using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Account
    {
        
        private string accName;
        private string acid;
        private int balance;

        public string getAccName()
            {
                return accName;
            }
        public void setAccName(string AccName)
            {
                accName = AccName;
            }

        public string getAcid()
        {
            return acid;
        }
        public void setAcid(string Acid)
        {
            acid = Acid;
        }

        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int Balance)
        {
            balance = Balance;
        }
        public Account()
        {
            Console.WriteLine("Empty Constructor");
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;

        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(int amount)
        {
            balance = balance - amount;    
        }

        public void Transfer(int amount, Account receiver)
        {
            receiver.balance = balance + amount;
        }
       
    }
}
