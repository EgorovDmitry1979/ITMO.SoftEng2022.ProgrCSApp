using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab6Ex3_2 //Добавить метод Withdraw в класс BankAccount
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        public bool Withdraw(decimal amount) //newlab6.3.2
        {
            bool sufficientFunds = accBal >= amount; //newlab6.3.2
            if (sufficientFunds) //newlab6.3.2
            {
                accBal -= amount; //newlab6.3.2
            }
            return sufficientFunds; //newlab6.3.2
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
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount acc) //newlab6.3.2
        {
            Console.Write("Enter amount to withdraw: "); //newlab6.3.2
            decimal amount = decimal.Parse(Console.ReadLine()); //newlab6.3.2
            if (!acc.Withdraw(amount)) //newlab6.3.2
            {
                Console.WriteLine("Insufficient funds (Недостаточно средств)."); //newlab6.3.2
            }
        }

        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts); //newlab6.3.2
            Write(berts); //newlab6.3.2

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds); //newlab6.3.2
            Write(freds); //newlab6.3.2
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
