using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab6Ex1_1 //Преобразуйте структуру BankAccount в класс
{
    public enum AccountType { Checking, Deposit }//из л.р.2
    //struct BankAccount // 
        class BankAccount // по инструкции
    {
        public long accNo; // из л.р.2
        public decimal accBal; // из л.р.2
        public AccountType accType; // из л.р.2
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
            BankAccount created = new BankAccount(); //по инструкции

            Console.Write("Enter the account number   : ");
            long number = long.Parse(Console.ReadLine());

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.accNo = number;
            created.accBal = balance;
            created.accType = AccountType.Checking;

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.accNo);
            Console.WriteLine("Account balance is {0}", toWrite.accBal);
            Console.WriteLine("Account type is {0}", toWrite.accType.ToString());
        }
    }
}
