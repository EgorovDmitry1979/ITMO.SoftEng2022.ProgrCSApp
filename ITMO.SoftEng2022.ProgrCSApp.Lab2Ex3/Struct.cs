using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab2Ex3
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    internal class Struct
    {
        public static void Main(string[] args)
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            //goldAccount.accNo = 123;
            Console.WriteLine("Если ввести 123 то будут сведения о счете, иначе - некорректный номер");
            Console.WriteLine(" "); //Это просто пробел
            Console.WriteLine("Enter account number: ");

            goldAccount.accNo = long.Parse(Console.ReadLine()); //без преобразования не работает

            if (goldAccount.accNo == 123)
            {
                Console.WriteLine("*** Account Summary ***");
                Console.WriteLine("Acct Number {0}", goldAccount.accNo);
                Console.WriteLine("Acct Type {0}", goldAccount.accType);
                Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            }
            else
            {
                Console.WriteLine("Incorrect Account Number");
            }
        }
    }
}