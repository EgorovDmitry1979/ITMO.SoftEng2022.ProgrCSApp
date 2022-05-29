using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab6Ex2_2 //Продолжите инкапсуляцию данных класса BankAccount
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        // public void Populate(long number, decimal balance) //по инструкции
        public void Populate(decimal balance) //new
        {
            //accNo = number; // по инструкции
            accNo = NextNumber(); //new
            accBal = balance;
            accType = AccountType.Checking;
        }

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
        //public static long NextNumber() //по инструкции
            private static long NextNumber() //new
        {
            return nextAccNo++;
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

            //long number = BankAccount.NextNumber(); // по инструкции

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.Populate(number, balance); // по инструкции
            created.Populate(balance); //new

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
