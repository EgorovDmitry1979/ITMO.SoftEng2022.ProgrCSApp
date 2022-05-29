using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab6Ex1_2 //Инкапсулируйте данные класса BankAccount
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo; //в 6.1.1. был public
        private decimal accBal; //в 6.1.1. был public
        private AccountType accType; //в 6.1.1. был public

        public void Populate(long number, decimal balance) //new
        {
            accNo = number; 
            accBal = balance; //new
            accType = AccountType.Checking; //new
        }

        public long Number() //new2
        {
            return accNo; //new2
        }
        public decimal Balance() //new2
        {
            return accBal; //new2
        }
        public AccountType Type() //new2
        {
            return accType; // new2
        }

    }
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }
        static BankAccount NewBankAccount()
        {
            //BankAccount created;
            BankAccount created = new BankAccount(); 

            Console.Write("Enter the account number   : ");
            long number = long.Parse(Console.ReadLine());

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number; //по инструкции
            //created.accBal = balance; //по инструкции
            //created.accType = AccountType.Checking; //по инструкции

            created.Populate(number, balance); // по инструкции

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            //Console.WriteLine("Account number is {0}", toWrite.accNo); // по инструкции
            //Console.WriteLine("Account balance is {0}", toWrite.accBal); // по инструкции
            //Console.WriteLine("Account type is {0}", toWrite.accType.ToString()); // по инструкции
            
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
    }
}
