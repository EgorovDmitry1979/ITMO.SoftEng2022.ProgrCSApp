using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab6Ex3_1 //Добавить метод Deposit в класс BankAccount
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public decimal Deposit(decimal amount) //newlab6.3.1
        {
            accBal += amount; //newlab6.3.1
            return accBal; //newlab6.3.1
        }

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
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
            private static long NextNumber()
        {
            return nextAccNo++;
        }

    }
    class CreateAccount
    {
        public static void TestDeposit(BankAccount acc) //newlab6.3.1
        {
            Console.Write("Enter amount to deposit: "); //newlab6.3.1
            decimal amount = decimal.Parse(Console.ReadLine()); //newlab6.3.1
            acc.Deposit(amount); //newlab6.3.1
        }

        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts); //newlab6.3.1
            Write(berts); //newlab6.3.1

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds); //newlab6.3.1
            Write(freds); //newlab6.3.1
        }
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

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
