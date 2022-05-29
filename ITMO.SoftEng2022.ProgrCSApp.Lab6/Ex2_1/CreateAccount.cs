using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab6Ex2_1 //Сделайте номер каждого банковского счета уникальным
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }

        private static long nextAccNo = 123; //new

        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
            public string Type()
        {
            return accType.ToString();
        }
        public static long NextNumber() //new
        {
            return nextAccNo++; //new
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
            BankAccount created = new BankAccount();

            //Console.Write("Enter the account number   : ");
            //long number = long.Parse(Console.ReadLine()); //по инструкции
            
            long number = BankAccount.NextNumber(); //new

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(number, balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        { 
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
    }
}
