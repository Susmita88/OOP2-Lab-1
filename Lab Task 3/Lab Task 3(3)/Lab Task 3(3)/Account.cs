using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_3_3_
{
    class Account
    {
        string accName, accId;
        int balance;
   
        public string getAccName()
        {
            return accName;
        }
        public void setAccName(string AccName)
        {
            accName = AccName;
        }
        public string getAccId()
        {
            return accId;
        }
        public void setAccId(string AccId)
        {
            accId = AccId;
        }
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int Balance)
        {
            balance = Balance;
        }
         public void Deposit(int ammount)
        {
            balance = balance + ammount;
        }
        public void withdraw(int ammount)
        {
            balance = balance - ammount;
        }

    }
    
}
